using System;


namespace UserRegistrationValidator
{
    class UserRegistration
    {
        static void Main(string[] args)
        {
            {
                Pattern pattern = new Pattern();

               
                bool resultOfPincode=pattern.ValidatePinCode("460551");
                Console.WriteLine("resultOfPincode   "+resultOfPincode);

                bool resultOfFirstName= pattern.ValidateFirstName("Sailesh");
                Console.WriteLine("resultOfFirstName  "+resultOfFirstName);

                bool resultOfLastName=pattern.ValidateLastName("Chauhan");
                Console.WriteLine("resultOfLastName   "+resultOfLastName);

                //The parameters for ValidateEmail is in separate class EmailSampleFile
                EmailSampleFile emailsample = new EmailSampleFile();
                emailsample.ValidateEmail();

                bool resultOfMobileFormat=pattern.ValidateMobileFormat("+91 8956231456");
                Console.WriteLine("resultOfMobileFormat "+resultOfMobileFormat);

                bool resultOfInvalidatePassword=pattern.CatchInValidatePassword("Sunder@123");
                Console.WriteLine("resultOfPassword     "+resultOfInvalidatePassword);

                //Implementing Reflection for Pattern class
                ReflectionInUserRegistration.Reflection();

                Console.ReadKey();
            }

        }
    }
}
