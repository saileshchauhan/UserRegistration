using System;


namespace RegexPattern
{
    class UserRegistration
    {
        static void Main(string[] args)
        {
            {
                Pattern pattern = new Pattern(string.Empty);

                //Implemented try and catch custom exception
                pattern.ValidatePinCode(pattern.message);
                
                //Implemented try and catch custom exception
                pattern.ValidateFirstName(pattern.message);
                
                pattern.ValidateLastName("Mayawati");
                
                //The parameters for ValidateEmail is in separate class EmailSampleFile
                EmailSampleFile emailsample = new EmailSampleFile();
                emailsample.ValidateEmail();

                pattern.ValidateMobileFormat("+91 8956231456");
                
                pattern.CatchInValidatePassword("Sunder@123");
                
                Console.ReadKey();
            }

        }
    }
}
