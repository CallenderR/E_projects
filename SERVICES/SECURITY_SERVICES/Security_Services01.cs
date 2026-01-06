
using E_APP02.TEMPLATE.TEXTS;
using System.Text.RegularExpressions;

namespace E_APP02.SERVICES.SECURITY_SERVICES
{

    internal class Security_Services01
    {
        private static string[] data01 = new string[3];
        public static bool empty_string(string input)
        {
            if (input != string.Empty &&
                input != " " &&
                !string.IsNullOrEmpty(input) &&
               input != "" &&
               !string.IsNullOrWhiteSpace(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool string_only_digit(string input)
        {
            if (input.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool string_has_special_character(string input)
        {

            if (Regex.IsMatch(input, Default_Text02.Regex01[0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool string_has_uppercase_character(string input)
        {
            if (input.Any(char.IsUpper))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool string_has_digit_character(string input)
        {
            if (input.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool string_has_length(string input)
        {
            int length = 15;
            if (input.Length >= length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool password_check(string input)
        {
            if (string_has_special_character(input) == true &&
                string_has_uppercase_character(input) == true &&
                string_has_digit_character(input) == true &&
                string_has_length(input) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool age_check(string input)
        {
            DateTime dateTime = DateTime.Now;
            int current_year = dateTime.Year;
            int birth_year = int.Parse(input);
            int age = current_year - birth_year;
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public static bool email_check(string input)
        {
            if (Regex.IsMatch(input, Default_Text02.Regex01[1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}