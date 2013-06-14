using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlickrREST.Model
{
    public class QuickSearchResultItem
    {
        public bool canfave { get; set; }
        public string character_name { get; set; }
        public string count_comments { get; set; }
        public string count_faves { get; set; }
        public string description { get; set; }
        public string full_name { get; set; }
        public string height { get; set; }

        public string id { get; set; }
        public string is_family { get; set; }
        public bool is_fave { get; set; }
        public string is_friend { get; set; }
        public string is_public { get; set; }
        public bool is_video { get; set; }
        public string name { get; set; }
        public int needs_interstitial { get; set; }
        public string nsid { get; set; }
        public string ownername { get; set; }
        public string photo_url { get; set; }
        public bool show_fuzzies { get; set; }
        public string size { get; set; }
        public QuickSearchImageSizes sizes { get; set; }
        public string spaceball { get; set; }
        public string src { get; set; }
        public string user_url { get; set; }
        public string width { get; set; }
    }
    public class QuickSearchImageSizes
    {
        public PhotoSize l { get; set; }
        public PhotoSize m { get; set; }
        public PhotoSize n { get; set; }
        public PhotoSize o { get; set; }
        public PhotoSize q { get; set; }
        public PhotoSize s { get; set; }
        public PhotoSize sq { get; set; }
        public PhotoSize t { get; set; }
        public PhotoSize z { get; set; }

        public PhotoSize GetLagestSize()
        {
            if (o != null) return o;
            if (l != null) return l;
            if (z != null) return z;
            if (m != null) return m;
            if (n != null) return n;
            if (s != null) return s;
            if (q != null) return q;
            if (sq != null) return sq;
            return null;
        }
    }
}
