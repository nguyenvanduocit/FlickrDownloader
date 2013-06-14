using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flickrdownloader
{
    public class DoWorkRresponse
    {
        public enum CODE {SUCCESS, NOIMAGEFOUND,NOINTERNETCONNECTION,PHOTOSERNOTFOUND,SERVICEUNAVAILABLE,UNKNOWERROR, PERMISSIONDENIED}
        public DoWorkRresponse(CODE code, string msg)
        {
            Code = code;
            Msg = msg;
        }
        public CODE Code { get; set; }
        public string Msg {get;set;}
    }
}
