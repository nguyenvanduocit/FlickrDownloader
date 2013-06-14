using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlickrREST.Exceptions
{
    public class FlickrAPIException : Exception
    {
        public FlickrAPIException(string code, string msg)
        {
            Code = code;
            Msg = msg;
        }

        public string Code { get; set; }
        public string Msg { get; set; }
    }
}
