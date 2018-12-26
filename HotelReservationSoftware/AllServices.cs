using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmAllServices : Form
    {
        private int serviceID;
        private string serviceName;
        private decimal servicePrice;
        private long bookingID;
        private bool IsAllServicesButtonClicked;
        private int UserLevelID;

        public frmAllServices(long bookingid, bool isClicked, int userLevelID)
        {
            InitializeComponent();
            bookingID = bookingid;
            IsAllServicesButtonClicked = isClicked;

            if (userLevelID > 2)
                btnAddNewService.Enabled = false;
            UserLevelID = userLevelID;
        }

        private void frmAllServices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementSystemDataSet1.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.hotelManagementSystemDataSet1.Services);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!IsAllServicesButtonClicked)
            {
                if (dgvAllServices.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvAllServices.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvAllServices.Rows[selectedRowIndex];

                    serviceID = Convert.ToInt16(selectedRow.Cells["dgvtxtServiceID"].Value);
                    serviceName = Convert.ToString(selectedRow.Cells["dgvtxtServiceName"].Value);
                    servicePrice = Convert.ToDecimal(selectedRow.Cells["dgvtxtServicePrice"].Value);

                    frmAddService frmAddService = new frmAddService(-1, bookingID, serviceID, serviceName, servicePrice, 0, UserLevelID, true, true);
                    frmAddService.Show();
                }
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = new DialogResult();
            dlgResult = MyMessageBox.ShowMessage("Сигурни ли сте, че искате да излезете?", "Отхвърляне на промени", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult.ToString() == "Yes")
            {
                Close();
            }
        }

        private void btnAddNewService_Click(object sender, EventArgs e)
        {
            frmAddNewService frmAddNewService = new frmAddNewService();
            frmAddNewService.Show();
        }

        private void frmAllServices_Activated(object sender, EventArgs e)
        {
            this.servicesTableAdapter.Fill(this.hotelManagementSystemDataSet1.Services);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (var db = new HotelManagementSystemEntities())
            {
                var query = db.Services.Where(s => s.ServiceName.StartsWith(txtFilter.Text)).ToList();

                dgvAllServices.DataSource = null;
                dgvAllServices.Rows.Clear();
                foreach (var item in query)
                {
                    dgvAllServices.Rows.Add(item.ServiceID, item.ServiceName, item.ServicePrice);
                }
            }
        }
    }
}
