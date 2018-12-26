using System;
using System.Text.RegularExpressions;

namespace HotelReservationSoftware
{
    internal class Validation
    {
        public bool isPasswordMatch(string pass, string pass1)
        {
            if (pass1.Equals(pass))
                return true;
            return false;
        }

        public bool isValidEmail(string email)
        {
            if (Regex.IsMatch(email, @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"))
                return true;
            return false;
        }

        public bool isValidPhone(string phone)
        {
            Regex regex = new Regex(@"^(\+[0-9]{3})*([0-9]{9})$");
            if (regex.IsMatch(phone))
                return true;
            return false;
        }

        public bool isValidTextField(string textField)
        {
            Regex regex = new Regex("^([A-Za-z-А-Яа-я ])");
            if (regex.IsMatch(textField))
                return true;
            return false;
        }

        public bool isValidNumberField(string numberField)
        {
            Regex regex = new Regex("^([0-9])");
            if (regex.IsMatch(numberField))
                return true;
            return false;
        }

        public bool isValidPrice(string price)
        {
            Regex regex = new Regex(@"^([0-9.])$");
            if (regex.IsMatch(price))
                return true;
            return false;
        }

        /*public static bool Mod10Check(string creditCardNumber)
        {
            // https://www.codeproject.com/Tips/515367/Validate-credit-card-number-with-Mod-algorithm

            //// 1.	Starting with the check digit, double the value of every other digit 
            //// 2.	If doubling of a number results in a two digits number, add up
            ///   the digits to get a single digit number. This will results in eight single digit numbers                    
            //// 3. Get the sum of all digits
            int sumOfDigits = creditCardNumber.Where((e) => e >= '0' && e <= '9')
                            .Reverse()
                            .Select((e, i) => ((int)e - 48) * (i % 2 == 0 ? 1 : 2))
                            .Sum((e) => e / 10 + e % 10);


            //// If the final sum is divisible by 10, then the credit card number
            //   is valid. If it is not divisible by 10, the number is invalid.            
            return sumOfDigits % 10 == 0;
        }*/

        public bool isValidCardNumber(string creditCardNumber)
        {
            int len, i, currentNumber, sum, sumOfOdds, sumOfEvens;
            string sumOdd = "";
            sum = sumOfEvens = sumOfOdds = 0;

            // if the card number doesn't contain only digits, return false
            if (!Regex.IsMatch(creditCardNumber, @"([0-9])$"))
                return false;

            // get the length of the card
            len = creditCardNumber.Length;
            for (i = 0; i < len; i++)
            {
                // get the current number in the string
                currentNumber = short.Parse(creditCardNumber[i].ToString());

                // if 'i' is even, save the current number in sumOfEvens and add it to the whole sum of digits.
                // Otherwise, multiply the current number by 2 and check if the result number is 2-digits long.
                // If this is true, add up the digits to get a single digit number.
                if (i % 2 != 0)
                {
                    sumOfEvens = currentNumber;
                    sum += sumOfEvens;
                }
                else
                {
                    sumOfOdds = currentNumber * 2;
                    sumOdd = sumOfOdds.ToString();
                    if (sumOdd.Length == 2)
                        sumOfOdds = short.Parse(sumOdd[0].ToString()) + short.Parse(sumOdd[1].ToString());
                    sum += sumOfOdds;
                }
            }
            // If the final sum is divisible by 10, then the credit card number is valid.
            // Otherwise, the number is invalid.
            if (sum % 10 == 0)
                return true;

            return false;
        }

        public bool checkdate(int m, int d, int y)
        {
            DateTime date;
            if (DateTime.TryParse(string.Format("{0}-{1}-{2}", d, m, y), out date))
                return true;
            return false;
        }

        public bool isValidEGN(string egn)
        {
            int checksum, valid_checksum, egnsum;
            int[] egn_weights = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };

            // Проверка дали ЕГН–то съдържа само цифри и дължината му е равна на 10.
            if (!Regex.IsMatch(egn, @"([0-9])$") || egn.Length != 10)
                return false;

            int year = int.Parse(egn.Substring(0, 2));
            int month = int.Parse(egn.Substring(2, 2));
            int day = int.Parse(egn.Substring(4, 2));

            if (month > 40)
            {
                if (!checkdate(month - 40, day, year + 2000))
                    return false;
            }
            else if (month > 20)
            {
                if (!checkdate(month - 20, day, year + 1800))
                    return false;
            }
            else
            {
                if (!checkdate(month, day, year + 1900))
                    return false;
            }

            checksum = int.Parse(egn.Substring(9, 1));
            egnsum = 0;
            for (int i = 0; i < 9; i++)
            {
                egnsum += int.Parse(egn.Substring(i, 1)) * egn_weights[i];
            }

            valid_checksum = egnsum % 11;
            if (valid_checksum == 10)
                valid_checksum = 0;

            return checksum == valid_checksum;
        }
    }
}
