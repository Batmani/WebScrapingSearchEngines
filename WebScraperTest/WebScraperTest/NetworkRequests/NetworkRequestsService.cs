﻿using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebScraperTest.NetworkRequests
{
    /// <summary>
    /// Service to deal with network queries.
    /// </summary>
    public class NetworkRequestsService : INetworkRequestsService
    {
        /// <summary>
        /// Takes in a url and returns the stream html data.
        /// </summary>
        /// <param name="url">The url to return data.</param>
        /// <returns>The stream data of the html request</returns>
        public StreamReader GetResponseData(string url)
        {
            var webRequest = HttpWebRequest.Create(url);
            var response = (HttpWebResponse)webRequest.GetResponse();

            Stream stream = response.GetResponseStream();
            var streamReader = new StreamReader(stream);
            return streamReader;
        }
    }

    public interface INetworkRequestsService
    {
        StreamReader GetResponseData(string url);
    }
}
