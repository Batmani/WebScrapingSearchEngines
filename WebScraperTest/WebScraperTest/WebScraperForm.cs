using System;
using System.IO;
using System.Windows.Forms;

namespace WebScraperTest
{
    public partial class WebScraperForm : Form
    {
        private WebScraperPresenter.WebScraperPresenter webScraperPresenter;

        public WebScraperForm()
        {
            InitializeComponent();
            InitializeServices();
            webScraperPresenter.InitializeScraping("Billie Eilish - Therefore I am");
            webScraperPresenter.InitializeScraping("Ariana Grande - Positions");
            webScraperPresenter.InitializeScraping("Shawn Mendes - Monster");

            dataGridView1.DataSource = webScraperPresenter.ScrapedSearchResults;
        }

        public void InitializeServices()
        {
            webScraperPresenter = new WebScraperPresenter.WebScraperPresenter();
        }


        private void buttonOpenFolderLocation_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string backupFileName = $"SearchResultsCSV{DateTime.Now.ToString("yyyy_mm_dd_HHmmss")}.csv";
                textFileLocation.Text = Path.Combine(folderBrowserDialog1.SelectedPath, backupFileName);
                buttonSaveToCSV.Enabled = true;
            }
        }

        private void buttonSaveToCSV_Click(object sender, EventArgs e)
        {
            webScraperPresenter.ConvertToCSV(webScraperPresenter.ScrapedSearchResults, textFileLocation.Text);

        }
    }
}
