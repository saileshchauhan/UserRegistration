using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidator
{
    public class Pattern
    {
        const string REGEX_PASSWORD = "^(.{0,7}|[^0-9]*|[^A-Z]*|[^a-z]*|[a-zA-Z0-9]*)$";
        const string REGEX_MOBILE = "^[+][0-9]{1,3}[ ][1-9]{1}[0-9]{9}$";
        const string REGEX_LASTNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string REGEX_FIRSTNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string REGEX_PINCODE = "^[1-9]{1}[0-9]{2,2}[ ]?[0-9]{3}$";
        
        
        public Func<string, bool> ValidatePinCode = (string pinCode) =>
           { return Regex.IsMatch(pinCode, REGEX_PINCODE); };
        
        public Func<string, bool> ValidateFirstName = (string firstName) => 
           { return Regex.IsMatch(firstName, REGEX_FIRSTNAME); };

        public Func<string, bool> ValidateLastName = (string lastName) =>
           { return Regex.IsMatch(lastName, REGEX_LASTNAME); };

        public Func<string, bool> ValidateMobileFormat = (string MobileNumber) =>
           { return Regex.IsMatch(MobileNumber, REGEX_MOBILE); };

        public Func<string, bool> CatchInValidatePassword = (string Password) =>
           { return !Regex.IsMatch(Password, REGEX_PASSWORD); };
        
    }
}
