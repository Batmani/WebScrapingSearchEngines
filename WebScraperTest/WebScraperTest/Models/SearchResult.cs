namespace WebScraperTest.Models
{
    /// <summary>
    /// The model to contain search results.
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        /// The rank of the search result.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// The title of the search result.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The url of the search result.
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// The search term of the search result.
        /// </summary>
        public string SearchTerm { get; set; }
    }
}
