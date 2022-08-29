using System.Text;

namespace RestNetCore.Hypermedia
{
    public class HyperMediaLink
    {
        public string Rel { get; set; }
        private string HrefTemp;
        public string Href
        {
            get
            {
                object _lock = new();
                lock (_lock)
                {
                    StringBuilder sb = new(HrefTemp);
                    return sb.Replace("%2F", "/").ToString();
                }
            }
            set
            {
                HrefTemp = value;
            }
        }

        public string Action { get; set; }
        public string Type { get; set; }

    }
}
