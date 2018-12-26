namespace HotelReservationSoftware
{
    partial class MonthsGuests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthsGuests));
            this.chartMonthGuests = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statisticForMonthsAndGuestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statisticForMonthsAndGuestsDataSet = new HotelReservationSoftware.StatisticForMonthsAndGuestsDataSet();
            this.statisticForMonthsAndGuestsTableAdapter = new HotelReservationSoftware.StatisticForMonthsAndGuestsDataSetTableAdapters.StatisticForMonthsAndGuestsTableAdapter();
            this.panel = new System.Windows.Forms.Panel();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticForMonthsAndGuestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticForMonthsAndGuestsDataSet)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartMonthGuests
            // 
            this.chartMonthGuests.BackColor = System.Drawing.Color.PaleTurquoise;
            chartArea1.Name = "ChartArea1";
            this.chartMonthGuests.ChartAreas.Add(chartArea1);
            this.chartMonthGuests.DataSource = this.statisticForMonthsAndGuestsBindingSource;
            legend1.Name = "Legend1";
            this.chartMonthGuests.Legends.Add(legend1);
            this.chartMonthGuests.Location = new System.Drawing.Point(0, 0);
            this.chartMonthGuests.Name = "chartMonthGuests";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.MediumTurquoise;
            series1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.Name = "Брой гости";
            series1.XValueMember = "Month";
            series1.YValueMembers = "NumberOfGuests";
            this.chartMonthGuests.Series.Add(series1);
            this.chartMonthGuests.Size = new System.Drawing.Size(1071, 557);
            this.chartMonthGuests.TabIndex = 0;
            this.chartMonthGuests.Text = "chart1";
            title1.Name = "MonthGuests";
            title1.Text = "Месец - брой гости";
            this.chartMonthGuests.Titles.Add(title1);
            // 
            // statisticForMonthsAndGuestsBindingSource
            // 
            this.statisticForMonthsAndGuestsBindingSource.DataMember = "StatisticForMonthsAndGuests";
            this.statisticForMonthsAndGuestsBindingSource.DataSource = this.statisticForMonthsAndGuestsDataSet;
            // 
            // statisticForMonthsAndGuestsDataSet
            // 
            this.statisticForMonthsAndGuestsDataSet.DataSetName = "StatisticForMonthsAndGuestsDataSet";
            this.statisticForMonthsAndGuestsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statisticForMonthsAndGuestsTableAdapter
            // 
            this.statisticForMonthsAndGuestsTableAdapter.ClearBeforeFill = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chartMonthGuests);
            this.panel.Location = new System.Drawing.Point(24, 97);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1071, 557);
            this.panel.TabIndex = 3;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(198, 21);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(134, 56);
            this.btnShowReport.TabIndex = 5;
            this.btnShowReport.Text = "Покажи отчет";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.Location = new System.Drawing.Point(24, 21);
            this.btnShowStatistics.Name = "btnShowStatistics";
            this.btnShowStatistics.Size = new System.Drawing.Size(134, 56);
            this.btnShowStatistics.TabIndex = 4;
            this.btnShowStatistics.Text = "Покажи статистика";
            this.btnShowStatistics.UseVisualStyleBackColor = true;
            this.btnShowStatistics.Click += new System.EventHandler(this.btnShowStatistics_Click);
            // 
            // MonthsGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1107, 666);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.btnShowStatistics);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MonthsGuests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Месец - гости";
            this.Load += new System.EventHandler(this.MonthsGuests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticForMonthsAndGuestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticForMonthsAndGuestsDataSet)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthGuests;
        private StatisticForMonthsAndGuestsDataSet statisticForMonthsAndGuestsDataSet;
        private System.Windows.Forms.BindingSource statisticForMonthsAndGuestsBindingSource;
        private StatisticForMonthsAndGuestsDataSetTableAdapters.StatisticForMonthsAndGuestsTableAdapter statisticForMonthsAndGuestsTableAdapter;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Button btnShowStatistics;
    }
}