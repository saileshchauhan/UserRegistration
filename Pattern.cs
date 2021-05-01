using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidator
{
    public class Pattern
    {
        const string REGEX_PASSWORD = "^(.{0,7}|[^0-9]*|[^A-Z]*|[^a-z]*|[a-zA-Z0-9]*)$";
        const string REGEX_MOBILE="^[+][0-9]{1,3}[ ][1-9]{1}[0-9]{9}$";
        const string REGEX_EMAIL = "^[a-z0-9A-Z]+([./*$#%][a-zA-Z0-9]{1,})?[@][a-zA-Z]{2,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2})?$";
        const string REGEX_LASTNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string REGEX_FIRSTNAME = "^[A-Z]{1}[a-z]{2,}$";
        const string REGEX_PINCODE = "^[1-9]{1}[0-9]{2,2}[ ]?[0-9]{3}$";
        public string message;
        //constructor for creating empty string object 
        public Pattern(string message)
        {
            this.message = message;
        }
        //Costum Exception Implemented
        public void ValidatePinCode(string pincode)
        {
            try
            {
                if (pincode.Equals(string.Empty))
                    throw new Exception("Your Entered Pincode is empty");
                bool result = (Regex.IsMatch(pincode, REGEX_PINCODE));
                Console.WriteLine(result);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public void ValidateFirstName(string FirstName)
        {
            try
            {
                if (FirstName.Equals(string.Empty))
                    throw new Exception("Your Entered FirstName is empty");
                bool result = Regex.IsMatch(FirstName, REGEX_FIRSTNAME);
                Console.WriteLine(result);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public void ValidateLastName(string LastName)
        {
            try
            {
                if (LastName.Equals(string.Empty))
                    throw new Exception("Your Entered LastName is empty");
                bool result = Regex.IsMatch(LastName, REGEX_LASTNAME);
                Console.WriteLine(result);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ValidateEmail(string Email)
        {
            try
            {
                if (Email.Equals(string.Empty))
                    throw new Exception("Your Entered Email is empty");
                bool result = Regex.IsMatch(Email, REGEX_EMAIL);
                Console.WriteLine(result);
            }catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ValidateMobileFormat(string MobileNumber)
        {
            try
            {
                if (MobileNumber.Equals(string.Empty))
                    throw new Exception("Your Entered Mobile Number is empty");
                bool result = Regex.IsMatch(MobileNumber, REGEX_MOBILE);
                Console.WriteLine(result);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
        public void CatchInValidatePassword(string Password)
        {
            try
            {
                if (Password.Equals(string.Empty))
                    throw new Exception("Your Entered Password is empty");
                bool result = Regex.IsMatch(Password, REGEX_PASSWORD);
                result = !result;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
