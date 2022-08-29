using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;
using RestNetCore.Hypermedia.Abstract;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestNetCore.Hypermedia
{
    public abstract class ContenteResponseEnricher<T> : IResponseEnricher where T : ISupportsHyperMedia
    {

        public ContenteResponseEnricher()
        {

        }

        public virtual bool CanEnrich(Type contextType)
        {
            return contextType == typeof(T) || contextType == typeof(List<T>);
        }

        protected abstract Task EnrichModel(T content, IUrlHelper urlHelper);

        bool IResponseEnricher.CanEnrich(ResultExecutingContext response)
        {
            if (response.Result is OkObjectResult okObjectResult)
            {
                return CanEnrich(okObjectResult.Value.GetType());
            }
            return false;
        }

        public async Task Enrich(ResultExecutingContext response)
        {
            var urlHelper = new UrlHelperFactory().GetUrlHelper(response);
            if (response.Result is OkObjectResult okObjectResult)
            {
                if (okObjectResult.Value is T model)
                {
                    await EnrichModel(model, urlHelper);
                }
                else if (okObjectResult.Value is List<T> colletion)
                {
                    ConcurrentBag<T> bag = new(colletion);
                    Parallel.ForEach(bag, (elemente) =>
                    {
                        EnrichModel(elemente, urlHelper);
                    });
                }
            }
            await Task.FromResult<object>(null);
        }
    }
}
