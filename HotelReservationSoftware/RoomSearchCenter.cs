﻿using System;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public partial class frmRoomSearchCenter : Form
    {
        public frmRoomSearchCenter()
        {
            InitializeComponent();
        }

        // Function that prevents moving of the form
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void frmRoomSearchCenter_Load(object sender, EventArgs e)
        {
            dtpToDate.Value = DateTime.Now.AddDays(1);
        }
    }
}
