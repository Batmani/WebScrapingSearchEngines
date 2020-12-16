using System.Collections.Generic;
using System.IO;
using WebScraperTest.Models;

namespace WebScraperTest
{
    /// <summary>
    /// A service to convert data to files.
    /// </summary>
    public class DataConversionService
    {
        /// <summary>
        /// Writes search results to a csv file.
        /// </summary>
        /// <param name="searchResults">The search results to write to.</param>
        /// <param name="path">The location to save the file.</param>
        public void SaveDataToCSV(List<SearchResult> searchResults, string path)
        {
            using (var file = File.CreateText(path))
            {
                foreach (var search in searchResults)
                {
                    file.Write(search.Order);
                    file.Write(",");
                    file.Write(search.SearchTerm);
                    file.Write(",");
                    file.Write(search.Url);
                    file.Write(",");
                    file.Write(search.Title);
                    file.Write(",");
                    file.WriteLine();
                }
            }
        }

    }

   
}
