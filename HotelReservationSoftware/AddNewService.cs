using System;
using System.Data.Entity.Validation;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmAddNewService : Form
    {
        public frmAddNewService()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool isAdded = false;
            string serviceName = txtServiceName.Text.ToString();
            string servicePrice = txtServicePrice.Text.ToString();

            Service service = new Service()
            {
                ServiceName = serviceName,
                ServicePrice = Decimal.Parse(servicePrice)
            };
           
            using (var db = new HotelManagementSystemEntities())
            {
                try
                {
                    db.Services.Add(service);
                    db.SaveChanges();
                    isAdded = true;
                }
                catch (DbEntityValidationException dbValidationEx)
                {
                    foreach (DbEntityValidationResult entityErr in dbValidationEx.EntityValidationErrors)
                    {
                        foreach (DbValidationError error in entityErr.ValidationErrors)
                        {
                            MessageBox.Show("Error: " + error.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            if (isAdded)
            {
                MyMessageBox.ShowMessage("Успешно добавихте услуга!", "Успешно добавяне на услуга в базата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MyMessageBox.ShowMessage("Сигурни ли сте, \nче искате да отхвърлите промените?", "Отхвърляне на промени",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
