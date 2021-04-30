﻿using System;


namespace RegexPattern
{
    class UserRegistration
    {
        static void Main(string[] args)
        {
            {
                Pattern pattern = new Pattern();
                
                bool resultPin = pattern.ValidatePinCode("460556");
                Console.WriteLine("Pin Validation Result  "+ resultPin);

                bool resultFirstName = pattern.ValidateFirstName("Sunder");
                Console.WriteLine("FirstName Validation Result  " + resultFirstName);

                bool resultLastName = pattern.ValidateLastName("Mayawati");
                Console.WriteLine("LastName Validation Result  " + resultLastName);

                //The parameters for ValidateEmail is in separate class EmailSampleFile
                EmailSampleFile emailsample = new EmailSampleFile();
                emailsample.ValidateEmail();

                bool resultMobileFormat = pattern.ValidateMobileFormat("+91 8956231456");
                Console.WriteLine("MobileFormat Validation Result  " + resultMobileFormat);
                
                bool resultPassword = pattern.CatchInValidatePassword("Sunderddd68eeeWWQW");
                resultPassword =! resultPassword;
                Console.WriteLine("Password Validation Result  " + resultPassword);


                Console.ReadKey();
            }

        }
    }
}
