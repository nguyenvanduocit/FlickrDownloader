using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlickrREST.Model;
using RestSharp;
using FlickrREST.Exceptions;
namespace FlickrREST
{
    public class FlickrApi
    {

        const string BaseUrl = "http://api.flickr.com/services/rest";
        public string api_key = "63072d29b6e277ca23a72d77a78278ce";
        public FlickrApi(String APIKey)
        {
            api_key = APIKey;
        }
        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient(BaseUrl);
            client.BaseUrl = BaseUrl;
            request.AddParameter("api_key", api_key);
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var flickrException = new ApplicationException(message, response.ErrorException);
                throw flickrException;
            }
            return response.Data;
        }

        public PhotosizeSet Photos_getSizes(string id)
        {
            RestRequest request = new RestRequest(Method.GET);
            request.AddParameter("method", "flickr.photos.getSizes");
            request.AddParameter("photo_id", id);
            try
            {
                GetPhotosizeResponse response = Execute<GetPhotosizeResponse>(request);
                if (response.stat == "ok")
                {
                    return response.sizes;
                }
                else
                {
                    var flickrException = new FlickrAPIException(response.err.code, response.err.msg);
                    throw flickrException;
                }
            }
            catch (ApplicationException ae)
            {
                throw ae;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters">http://www.flickr.com/services/api/explore/flickr.photos.search</param>
        /// <returns>Photoset</returns>
        public Photoset Photos_search(SearchParameter parameters, string page, string perpage)
        {
            RestRequest request = new RestRequest(Method.GET);
            request.AddParameter("method", "flickr.photos.search");
            request.AddParameter("media", "photos");
            request.AddParameter("extras", "url_q, url_t, url_z, url_c, url_b, url_o");
            request.AddParameter("page", page);
            request.AddParameter("per_page", perpage);
            request.AddParameter("text", "lotus");
            request.AddParameter("accuracy", "1");
            /*for(int i=0; i<parameters.Count; i++)
            {
                request.AddParameter(parameters.GetParameter(i));
            }*/
            try
            {
                PhotolistResponse response = Execute<PhotolistResponse>(request);
                if (response == null)
                {
                    var flickrException = new FlickrAPIException("-1", "No network connection");
                    throw flickrException;
                }
                if (response.stat == "ok")
                {
                    return response.photos;
                }
                else if (response.stat == "fail")
                {
                    var flickrException = new FlickrAPIException(response.err.code, response.err.msg);
                    throw flickrException;
                }
            }
            catch (ApplicationException ae)
            {
                throw ae;
            }
            return null;
        }

        public Photoset Photos_search(string tags, string page, string perpage)
        {
            SearchParameter sp = new SearchParameter();
            sp.AddParameter("tags", tags);
            return Photos_search(sp, page, perpage);
        }

        public List<QuickSearchResultItem> QuickSearch(string tag,int page,int  perpage)
        {
            RestClient client = new RestClient("http://www.flickr.com");
            string query = "search?data=1&q=" + RestSharp.Contrib.HttpUtility.UrlEncode(tag) + "&s=&page=" + page.ToString() + "&mt=photos&cm=&m=&l=&w=all&hd=&d=&append=1";
            RestRequest request = new RestRequest(query, Method.GET);
            RestResponse<List<QuickSearchResultItem>> response = (RestResponse<List<QuickSearchResultItem>>)client.Execute<List<QuickSearchResultItem>>(request);
            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }
            if (response.Data == null)
            {
                const string message = "Data response is null";
                var flickrException = new ApplicationException(message);
                throw flickrException;
            }
            return response.Data;
        }

        public Photoset Photosets_getPhotos(string id,string page, string perpage)
        {
            RestRequest request = new RestRequest(Method.GET);
            request.AddParameter("method", "flickr.photosets.getPhotos");
            request.AddParameter("media", "photos");
            request.AddParameter("extras", "url_q, url_t, url_z, url_c, url_b, url_o");
            request.AddParameter("photoset_id", id);
            request.AddParameter("page", page);
            request.AddParameter("per_page", perpage);
            try
            {
                PhotosetResponse response = Execute<PhotosetResponse>(request);
                if (response.stat == "ok")
                {
                    return response.photoset;
                }
                else if (response.stat == "fail")
                {
                    var flickrException = new FlickrAPIException(response.err.code, response.err.msg);
                    throw flickrException;
                }
            }
            catch (ApplicationException ae)
            {
                throw ae;
            }

            return null;
        }
    }
}
