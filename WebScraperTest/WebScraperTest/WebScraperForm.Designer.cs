namespace WebScraperTest
{
    partial class WebScraperForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSaveToCSV = new System.Windows.Forms.Button();
            this.textFileLocation = new System.Windows.Forms.TextBox();
            this.buttonOpenFolderLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1329, 649);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonSaveToCSV
            // 
            this.buttonSaveToCSV.Enabled = false;
            this.buttonSaveToCSV.Location = new System.Drawing.Point(914, 747);
            this.buttonSaveToCSV.Name = "buttonSaveToCSV";
            this.buttonSaveToCSV.Size = new System.Drawing.Size(187, 23);
            this.buttonSaveToCSV.TabIndex = 2;
            this.buttonSaveToCSV.Text = "Convert table to CSV";
            this.buttonSaveToCSV.UseVisualStyleBackColor = true;
            this.buttonSaveToCSV.Click += new System.EventHandler(this.buttonSaveToCSV_Click);
            // 
            // textFileLocation
            // 
            this.textFileLocation.Location = new System.Drawing.Point(481, 749);
            this.textFileLocation.Name = "textFileLocation";
            this.textFileLocation.Size = new System.Drawing.Size(315, 20);
            this.textFileLocation.TabIndex = 3;
            // 
            // buttonOpenFolderLocation
            // 
            this.buttonOpenFolderLocation.Location = new System.Drawing.Point(797, 749);
            this.buttonOpenFolderLocation.Name = "buttonOpenFolderLocation";
            this.buttonOpenFolderLocation.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFolderLocation.TabIndex = 4;
            this.buttonOpenFolderLocation.Text = "Browse";
            this.buttonOpenFolderLocation.UseVisualStyleBackColor = true;
            this.buttonOpenFolderLocation.Click += new System.EventHandler(this.buttonOpenFolderLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Web scraping google search results";
            // 
            // WebScraperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 866);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenFolderLocation);
            this.Controls.Add(this.textFileLocation);
            this.Controls.Add(this.buttonSaveToCSV);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WebScraperForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonSaveToCSV;
        private System.Windows.Forms.TextBox textFileLocation;
        private System.Windows.Forms.Button buttonOpenFolderLocation;
        private System.Windows.Forms.Label label1;
    }
}

