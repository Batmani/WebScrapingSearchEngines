using System.IO;
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
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMsg = client.GetAsync(url).Result;
            Task<string> responseBody = responseMsg.Content.ReadAsStringAsync();
            
            responseBody.Wait();
            
            var res = responseBody.Result;
            byte[] byteArray = Encoding.ASCII.GetBytes(res);
            MemoryStream stream = new MemoryStream(byteArray);
            
            return new StreamReader(stream);
        }
    }

    public interface INetworkRequestsService
    {
        StreamReader GetResponseData(string url);
    }
}
