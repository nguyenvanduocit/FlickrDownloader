using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlickrREST.Model
{
    public class PhotolistResponse
    {
        public string stat { get; set; }
        public Err err { get; set; }
        public Photoset photos { get; set; }
    }
}
