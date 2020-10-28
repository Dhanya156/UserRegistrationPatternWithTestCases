using System;
using System.Text.RegularExpressions;

namespace UserRegistrationPattern
{
    ///Creating a class Validation whch have reference in Test class
    public class Validation
    {
        /// Pattern to check FirstName which accpets minimum 3 characters and starts with Uppercase
        public static string REGEX_NAME = "^[A-Z]+[a-z]{2,}";

        ///Email has 3 mandatory parts (abc, bl& co) and 2 optional(xyz & in) with precise @ and.positions
        public static string REGEX_EMAIL = "^[a-z]+[0-9]*([-_+.][0-9a-z]+)*@[0-9a-z]+[.][a-z]{2,4}([,]{1})*([.][a-z]{2})*$";

        /// 10 digit Number starts from 1 to 9
        public static string REGEX_PHONENUMBER = "^[1-9]?[0-9]{9}";

        ///minimum 8 Characters        
        ///Atleast one Uppercase
        ///Atleast one Lowercase
        ///Atleast one special character
        public static string REGEX_PASSWORD = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[@#%^&*!()<>?:;]).{8,}$";

        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Validation");
        }

        /// <summary>Validates the name.</summary>
        /// <param name="name">The name.</param>
        public static bool ValidateName(string name)
        {
            ///Returns True or False to indicate whether the pattern is matched in the string passed as arguement
            return Regex.IsMatch(name, REGEX_NAME);
        }

        /// <summary>Validates the email.</summary>
        /// <param name="email">The email.</param>
        public static bool ValidateEmail(string email)
        {
            ///Returns True or False to indicate whether the pattern is matched in the string passed as arguement
            return Regex.IsMatch(email, REGEX_EMAIL);
        }

        /// <summary>Validates the phone number.</summary>
        /// <param name="phoneNumber">The phone number.</param>
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            ///Returns True or False to indicate whether the pattern is matched in the string passed as arguement
            return Regex.IsMatch(phoneNumber, REGEX_PHONENUMBER);
        }

        /// <summary>Validates the phone number.</summary>
        /// <param name="password">The phone number.</param>
        public static bool ValidatePassword(string password)
        {
            ///Returns True or False to indicate whether the pattern is matched in the string passed as arguement
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
