using RestNetCore.Hypermedia;
using RestNetCore.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace RestNetCore.Data.VO
{
    public class BooksVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string Author { get; set; }
        public DateTime LaunchDate { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
