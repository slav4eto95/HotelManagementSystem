using System;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class Countries : Form
    {
        public Countries()
        {
            InitializeComponent();
        }

        private void ClearPanelContent()
        {
            if (panel.Controls.Count > 0)
            {
                panel.Controls.Clear();
            }
        }

        private void Countries_Load(object sender, EventArgs e)
        {
            ClearPanelContent();            
        }
        
        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            ClearPanelContent();
            chartCountries.Dock = DockStyle.Fill;

            this.statisticForCountriesTableAdapter.Fill(this.statisticForCountriesDataSet.StatisticForCountries);

            panel.Controls.Add(chartCountries);
            chartCountries.Show();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            ClearPanelContent();

            ReportViewerControl reportViewerControl = new ReportViewerControl("CountriesReport")
            {
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(reportViewerControl);
            reportViewerControl.Show();
        }
    }
}
