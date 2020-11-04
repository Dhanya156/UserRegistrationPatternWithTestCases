using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationPattern
{
    public class ValidationUsingLambda
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

        /// <summary>Validates the name.</summary>
        /// <param name="name">The name.</param>
        /// <returns>True or False/// </returns>
        public bool ValidateName(string name) => (Regex.IsMatch(name, REGEX_NAME));

        /// <summary>Validates the email.</summary>
        /// <param name="email">The name.</param>
        /// <returns>True or False/// </returns>
        public bool ValidateEmail(string email) => (Regex.IsMatch(email, REGEX_EMAIL));

        /// <summary>Validates the phone number.</summary>
        /// <param name="phoneNumber">The name.</param>
        /// <returns>True or False/// </returns>
        public bool ValidatePhoneNumber(string phoneNumber) => (Regex.IsMatch(phoneNumber, REGEX_PHONENUMBER));

        /// <summary>Validates the password.</summary>
        /// <param name="password">The name.</param>
        /// <returns>True or False/// </returns>
        public bool ValidatePassword(string password) => (Regex.IsMatch(password, REGEX_PASSWORD));

    }
}
