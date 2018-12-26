using System.Drawing;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmCustomMessageBoxOk : Form
    {
        public frmCustomMessageBoxOk()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string Message
        {
            get { return lblMessage.Text.ToString(); }
            set { lblMessage.Text = value; }
        }
    }
}
