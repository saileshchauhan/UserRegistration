using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    class Pattern
    {
        const string REGEX_PASSWORD = "^(.{0,7}|[^0-9]*|[^A-Z]*|[^a-z]*|[a-zA-Z0-9]*)$";
        const string REGEX_MOBILE="^[+][0-9]{1,3}[ ][1-9]{1}[0-9]{9}$";
        const string REGEX_EMAIL = "^[a-z0-9A-Z]+([./*$#%][a-zA-Z0-9]{1,})?[@][a-zA-Z]{2,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2})?$";
        const string REGEX_LASTNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string REGEX_FIRSTNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string REGEX_PINCODE = "^[1-9]{1}[0-9]{2,2}[ ]?[0-9]{3}$";

        public bool ValidatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE);
        }
        public bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, REGEX_FIRSTNAME);
        }
        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, REGEX_LASTNAME);
        }
        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, REGEX_EMAIL);
        }
        public bool ValidateMobileFormat(string Format)
        {
            return Regex.IsMatch(Format, REGEX_MOBILE);
        }
        public bool CatchInValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, REGEX_PASSWORD);
        }
    }
}
