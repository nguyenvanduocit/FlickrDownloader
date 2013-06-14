using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlickrREST.Model
{
    public class PhotosizeSet
    {
        public string canblog { set; get; }
        public string canprint { set; get; }
        public string candownload { set; get; }
        public List<PhotoSize> sizes { set; get; }
    }
}
