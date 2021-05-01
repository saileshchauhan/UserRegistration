using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidator
{
    public class EmailSampleFile
    {
        const string REGEX_EMAIL = "^[a-z0-9A-Z]+([.+-/$#%][a-zA-Z0-9]{1,})?[@][a-z0-9A-Z]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,3})?$";
        string[] validEmails = {"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com",
                                "abc-100@ABC.net","abc.100@abc.com.au","abc@1.com","abc@gmail.com.com",
                                "abc+100@gmail.com"};
        string[] inValidEmails = {"abc","abc123@gmail.a","abc123@.com","abc123@.com.com","abc()*@gmail.com",
                                  "abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a",
                                  "abc@gmail.com.aa.au"};

        
        public void ValidateEmail()
        {
            foreach (var Email in validEmails)
            {
                Console.WriteLine("ValidEmail Samples  "+Regex.IsMatch(Email, REGEX_EMAIL));
            }
            foreach (var EmailInvalid in inValidEmails)
            {
                Console.WriteLine("InValidEmail Samples " + Regex.IsMatch(EmailInvalid, REGEX_EMAIL));
            }
        }
        
    }
}
