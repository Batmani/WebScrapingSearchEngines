using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using HtmlAgilityPack;
using WebScraperTest.Models;

namespace WebScraperTest.WebScraper
{
    /// <summary>
    /// Service to scrape web data.
    /// </summary>
    public class WebScraperService : IWebScraperService
    {
        private HtmlDocument htmlDocument;

        /// <summary>
        /// Takes in raw stream data and returns the required list of SearchResult.
        /// </summary>
        /// <param name="searchTerm">The search term to be documented.</param>
        /// <param name="htmlStream">The raw stream data to be processed.</param>
        /// <returns>A list of SearchResult</returns>
        public List<SearchResult> ScrapeData(string searchTerm, StreamReader htmlStream)
        {
            ConvertStreamToHtmlDocument(htmlStream);
            var htmlNodeCollection = SelectHtmlDocumentNodes(htmlDocument, "//a[@href]");
            var nodesOrderedByPosition = OrderNodesByPosition(htmlNodeCollection);
            return GetSearchResultsData(nodesOrderedByPosition, searchTerm);
        }

        /// <summary>
        /// Filters and returns specific data of the node list.
        /// </summary>
        /// <param name="orderedNodelist">The ordered node list to be filtered.</param>
        /// <param name="searchTerm">The search term used in the method.</param>
        /// <returns>List of SearchResult entities.</returns>
        private List<SearchResult> GetSearchResultsData(List<HtmlNode> orderedNodelist,string searchTerm)
        {
            int order = 1;
            List<SearchResult> searchResults = new List<SearchResult>();

            foreach (var node in orderedNodelist)
            {
                string hrefValue = node.GetAttributeValue("href", string.Empty);
                

                if (hrefValue.Contains("/url?q="))
                {
                    //The html class tag for a new result
                    if (node.InnerHtml.Contains("BNeawe vvjwJb AP7Wnd"))
                    {
                        int index = hrefValue.IndexOf("&");
                        hrefValue = hrefValue.Substring(0, index);

                        if (hrefValue.Contains("twitter.com"))
                        {
                            int tempIndex = hrefValue.IndexOf("%");
                            hrefValue = hrefValue.Substring(0, tempIndex);
                        }

                        SearchResult searchResult = new SearchResult()
                        {
                            Url = hrefValue.Replace("/url?q=", ""),
                            Title = DecodeString(node.FirstChild.InnerText),
                            Order = order,
                            SearchTerm = searchTerm
                        };
                        order = order + 1;
                        searchResults.Add(searchResult);
                    }
                }
            }

            return searchResults;
        }

        /// <summary>
        /// Decodes an encoded string.
        /// </summary>
        /// <param name="encodedString">The encoded string to be decoded.</param>
        /// <returns></returns>
        private string DecodeString(string encodedString)
        {
            return WebUtility.HtmlDecode(encodedString);
        }

        /// <summary>
        /// Loads a HtmlDocument that takes in a stream.
        /// </summary>
        /// <param name="htmlStream">The stream that will be used.</param>
        private void ConvertStreamToHtmlDocument(StreamReader htmlStream)
        {
            htmlDocument = new HtmlDocument();
            htmlDocument.OptionFixNestedTags = true;
            htmlDocument.Load(htmlStream);
        }

        /// <summary>
        /// Selects nodes based on an xpath filter.
        /// </summary>
        /// <param name="htmlDoc">The HtmlDocument that will be filtered.</param>
        /// <param name="xpathFilter">The xpath.</param>
        /// <returns>A node collection based on the filter</returns>
        private HtmlNodeCollection SelectHtmlDocumentNodes(HtmlDocument htmlDoc, string xpathFilter)
        {
            return htmlDoc.DocumentNode.SelectNodes(xpathFilter);
        }

        /// <summary>
        /// Orders the nodes based on their actual position on the html page.
        /// </summary>
        /// <param name="nodeCollection">The collection to be ordered.</param>
        /// <returns>An ordered list of HtmlNode</returns>
        private List<HtmlNode> OrderNodesByPosition(HtmlNodeCollection nodeCollection)
        {
            return nodeCollection.OrderBy(node => node.StreamPosition).ToList<HtmlNode>();

        }
    }

    public interface IWebScraperService
    {
        List<SearchResult> ScrapeData(string searchTerm, StreamReader htmlStream);
    }
}
