using System.Drawing;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmCustomMessageBoxYesNo : Form
    {
        public frmCustomMessageBoxYesNo()
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
            get { return lblTextMessage.Text.ToString(); }
            set { lblTextMessage.Text = value; }
        }
    }
}
