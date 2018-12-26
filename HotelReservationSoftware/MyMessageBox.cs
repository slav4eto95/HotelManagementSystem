using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSoftware
{
    public static class MyMessageBox
    {
        public static System.Windows.Forms.DialogResult ShowMessage(string message, string caption, System.Windows.Forms.MessageBoxButtons buttons, System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.DialogResult.None;

            switch (buttons)
            {
                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (frmCustomMessageBoxYesNo msg = new frmCustomMessageBoxYesNo())
                    {
                        msg.Text = caption;
                        msg.Message = message;

                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                msg.MessageIcon = Properties.Resources.question_mark;
                                break;
                        }
                        dialogResult = msg.ShowDialog();
                    }
                    break;
                case System.Windows.Forms.MessageBoxButtons.OK:
                    using (frmCustomMessageBoxOk msg = new frmCustomMessageBoxOk())
                    {
                        msg.Text = caption;
                        msg.Message = message;

                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Error:
                                msg.MessageIcon = Properties.Resources.error;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Information:
                                msg.MessageIcon = Properties.Resources.information;
                                break;
                        }
                        dialogResult = msg.ShowDialog();
                    }
                    break;
            }

            return dialogResult;
        }
    }
}
