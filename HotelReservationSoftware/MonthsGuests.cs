using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class MonthsGuests : Form
    {
        public MonthsGuests()
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

        private void MonthsGuests_Load(object sender, EventArgs e)
        {
            ClearPanelContent();
        }

        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            ClearPanelContent();
            chartMonthGuests.Dock = DockStyle.Fill;

            // TODO: This line of code loads data into the 'statisticForMonthsAndGuestsDataSet.StatisticForMonthsAndGuests' table. You can move, or remove it, as needed.
            this.statisticForMonthsAndGuestsTableAdapter.Fill(this.statisticForMonthsAndGuestsDataSet.StatisticForMonthsAndGuests);

            panel.Controls.Add(chartMonthGuests);
            chartMonthGuests.Show();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            ClearPanelContent();

            ReportViewerControl reportViewerControl = new ReportViewerControl("MonthsGuestsReport")
            {
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(reportViewerControl);
            reportViewerControl.Show();
        }
    }
}