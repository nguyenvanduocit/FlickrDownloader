using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlickrREST.Model
{
    public class Photoset
    {
        public string id { get; set; }
        public string primary { get; set; }
        public string owner { get; set; }
        public string ownername { get; set; }
        public string page { get; set; }
        public string per_page { get; set; }
        public string perpage { get; set; }
        public string pages { get; set; }
        public string total { get; set; }
        public List<Photo> photos { get; set; }
    }
}
