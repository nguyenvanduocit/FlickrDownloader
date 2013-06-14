using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlickrREST.Model
{
    public class Photo
    {
        public string id { get; set; }
        public string secret { get; set; }
        public string server { get; set; }
        public string farm { get; set; }
        public string title { get; set; }
        public string url_q { get; set; }
        public string url_t { get; set; }
        public string url_z { get; set; }
        public string url_c { get; set; }
        public string url_b { get; set; }
        public string url_o { get; set; }

        public string GetLagestSizeURL()
        {
            if (url_o != null) return url_o;
            if (url_b != null) return url_b;
            if (url_c != null) return url_c;
            if (url_z != null) return url_z;
            if (url_t != null) return url_t;
            return url_q;
        }
    }
}
