namespace HotelReservationSoftware
{
    partial class Countries
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Countries));
            this.chartCountries = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statisticForCountriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statisticForCountriesDataSet = new HotelReservationSoftware.StatisticForCountriesDataSet();
            this.statisticForCountriesTableAdapter = new HotelReservationSoftware.StatisticForCountriesDataSetTableAdapters.StatisticForCountriesTableAdapter();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnShowReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticForCountriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticForCountriesDataSet)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartCountries
            // 
            this.chartCountries.BackColor = System.Drawing.Color.PaleTurquoise;
            chartArea1.Name = "ChartArea1";
            this.chartCountries.ChartAreas.Add(chartArea1);
            this.chartCountries.DataSource = this.statisticForCountriesBindingSource;
            legend1.Name = "Legend1";
            this.chartCountries.Legends.Add(legend1);
            this.chartCountries.Location = new System.Drawing.Point(0, 3);
            this.chartCountries.Name = "chartCountries";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.MediumTurquoise;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Брой гости";
            series1.XValueMember = "Country";
            series1.YValueMembers = "NumberOfGuests";
            this.chartCountries.Series.Add(series1);
            this.chartCountries.Size = new System.Drawing.Size(1071, 557);
            this.chartCountries.TabIndex = 0;
            this.chartCountries.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Държава - брой гости";
            this.chartCountries.Titles.Add(title1);
            // 
            // statisticForCountriesBindingSource
            // 
            this.statisticForCountriesBindingSource.DataMember = "StatisticForCountries";
            this.statisticForCountriesBindingSource.DataSource = this.statisticForCountriesDataSet;
            // 
            // statisticForCountriesDataSet
            // 
            this.statisticForCountriesDataSet.DataSetName = "StatisticForCountriesDataSet";
            this.statisticForCountriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statisticForCountriesTableAdapter
            // 
            this.statisticForCountriesTableAdapter.ClearBeforeFill = true;
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.Location = new System.Drawing.Point(24, 21);
            this.btnShowStatistics.Name = "btnShowStatistics";
            this.btnShowStatistics.Size = new System.Drawing.Size(134, 56);
            this.btnShowStatistics.TabIndex = 1;
            this.btnShowStatistics.Text = "Покажи статистика";
            this.btnShowStatistics.UseVisualStyleBackColor = true;
            this.btnShowStatistics.Click += new System.EventHandler(this.btnShowStatistics_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chartCountries);
            this.panel.Location = new System.Drawing.Point(24, 97);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1071, 557);
            this.panel.TabIndex = 2;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(198, 21);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(134, 56);
            this.btnShowReport.TabIndex = 2;
            this.btnShowReport.Text = "Покажи отчет";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // Countries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1107, 666);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.btnShowStatistics);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Countries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Държава - брой гости";
            this.Load += new System.EventHandler(this.Countries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticForCountriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticForCountriesDataSet)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountries;
        private StatisticForCountriesDataSet statisticForCountriesDataSet;
        private System.Windows.Forms.BindingSource statisticForCountriesBindingSource;
        private StatisticForCountriesDataSetTableAdapters.StatisticForCountriesTableAdapter statisticForCountriesTableAdapter;
        private System.Windows.Forms.Button btnShowStatistics;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnShowReport;
    }
}