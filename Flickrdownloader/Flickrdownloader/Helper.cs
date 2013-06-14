//Copy rights are reserved for Akram kamal qassas
//Email me, Akramnet4u@hotmail.com
using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Flickrdownloader
{
    public static class FormatLeftTime
    {
        private static string[] TimeUnitsNames = { "Milli", "Sec", "Min", "Hour", "Day", "Month", "Year", "Decade", "Century" };
        private static int[] TimeUnitsValue = { 1000, 60, 60, 24, 30, 12, 10, 10 };//refrernce unit is milli
        public static string Format(long millis)
        {
            string format = "";
            for (int i = 0; i < TimeUnitsValue.Length; i++)
            {
                long y = millis % TimeUnitsValue[i];
                millis = millis / TimeUnitsValue[i];
                if (y == 0) continue;
                format = y + " " + TimeUnitsNames[i] + " , " + format;
            }

            format = format.Trim(',', ' ');
            if (format == "") return "0 Sec";
            else return format;
        }
    }
    public static class Helper
    {

        public static IWebProxy InitialProxy()
        {
            string address = address = getIEProxy();
            if (!string.IsNullOrEmpty(address))
            {
                WebProxy proxy = new WebProxy(address);
                proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
                return proxy;
            }
            else return null;
        }
        private static string getIEProxy()
        {
            var p = WebRequest.DefaultWebProxy;
            if (p == null) return null;
            WebProxy webProxy = null;
            if (p is WebProxy) webProxy = p as WebProxy;
            else
            {
                Type t = p.GetType();
                var s = t.GetProperty("WebProxy", (BindingFlags)0xfff).GetValue(p, null);
                webProxy = s as WebProxy;
            }
            if (webProxy == null || webProxy.Address == null || string.IsNullOrEmpty(webProxy.Address.AbsolutePath))
                return null;
            return webProxy.Address.Host;
        }
    }
}
