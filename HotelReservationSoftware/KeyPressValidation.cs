using System;
using System.Windows.Forms;

namespace HotelReservationSoftware
{
    public class KeyPressValidation
    {
        public void acceptOnlyDigits(KeyPressEventArgs key)
        {
            if (Char.IsDigit(key.KeyChar) || key.KeyChar == (char)8) // accept backspace
                key.Handled = false;
            else
                key.Handled = true;
        }

        public void acceptOnlyLettersAndBackSpace(KeyPressEventArgs key)
        {
            if ((key.KeyChar > (char)64 && key.KeyChar < (char)91) ||
                (key.KeyChar > (char)96 && key.KeyChar < (char)123) ||
                key.KeyChar == (char)8 || Char.IsWhiteSpace(key.KeyChar))
            {
                key.Handled = false;
            }
            else
            {
                key.Handled = true;
            }
        }

        public void acceptOnlyAllKindOfLettersAndBackSpace(KeyPressEventArgs key)
        {
            if (Char.IsLetter(key.KeyChar) || key.KeyChar == (char)8 || Char.IsWhiteSpace(key.KeyChar))
            {
                key.Handled = false;
            }
            else
            {
                key.Handled = true;
            }
        }

        public void dontAcceptWhiteSpace(KeyPressEventArgs key)
        {
            if (!Char.IsWhiteSpace(key.KeyChar) || key.KeyChar == (char)8)
            {
                key.Handled = false;
            }
            else
                key.Handled = true;
        }

        public void acceptOnlyDigitsAndPlusSign(KeyPressEventArgs key)
        {
            if (Char.IsDigit(key.KeyChar) || key.KeyChar == '+' || key.KeyChar == (char)8)
            {
                key.Handled = false;
            }
            else
                key.Handled = true;
        }
    }
}
