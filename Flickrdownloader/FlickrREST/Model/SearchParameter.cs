using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlickrREST.Model
{
    public class SearchParameter
    {
        private List<Parameter> parameters;
        public SearchParameter()
        {
            parameters = new List<Parameter>();
        }
        public void AddParameter(string name, string value)
        { 
            Parameter parm = new RestSharp.Parameter();
            parm.Name = name;
            parm.Value = value;
            parameters.Add(parm);
        }
        public int Count
        {
            get {return parameters.Count;}
        }

        public Parameter GetParameter(int index)
        {
            if(index < parameters.Count)
            {
                return parameters[index];
            }
            throw new OverflowException();
        }
    }
}
