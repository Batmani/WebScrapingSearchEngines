using System.Collections.Generic;
using WebScraperTest.Models;
using WebScraperTest.NetworkRequests;
using WebScraperTest.WebScraper;

namespace WebScraperTest.WebScraperPresenter
{
    /// <summary>
    /// Presenter class that uses all components to scrape data.
    /// </summary>
    public class WebScraperPresenter
    {
        public List<SearchResult> ScrapedSearchResults;
        int numberOfResults = 20;

        private DataConversionService dataConversionMethods;
        private NetworkRequestsService networkService;
        private WebScraperService webScraper;

        public WebScraperPresenter()
        {
            InitializeServices();
        }

        /// <summary>
        /// Initializes component services.
        /// </summary>
        private void InitializeServices()
        {
            dataConversionMethods = new DataConversionService();
            networkService = new NetworkRequestsService();
            webScraper = new WebScraperService();
            ScrapedSearchResults = new List<SearchResult>();
        }

        /// <summary>
        /// Returns specified data from a google search term.
        /// </summary>
        /// <param name="searchTerm">TThe search term to be queried.</param>
        public void InitializeScraping(string searchTerm)
        {
            var filteredSearchTerm = searchTerm.Replace(" ", "+");
            string searchRequestUrl = $"https://www.google.com/search?q={filteredSearchTerm}&num={numberOfResults}";
            var responseData = networkService.GetResponseData(searchRequestUrl);

            ScrapedSearchResults.AddRange(webScraper.ScrapeData(searchTerm, responseData));
        }

        /// <summary>
        /// Calls the data conversion method to convert to a csv.
        /// </summary>
        /// <param name="searchResults">The search results to be converted.</param>
        /// <param name="fileLocation">The csv location to be saved to.</param>
        public void ConvertToCSV(List<SearchResult> searchResults, string fileLocation)
        {
            dataConversionMethods.SaveDataToCSV(searchResults, fileLocation);
        }
    }
}
