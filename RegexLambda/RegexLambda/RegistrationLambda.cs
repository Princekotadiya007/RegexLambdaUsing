using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexLambda
{
    public class RegistrationLambda
    {
        List<ModalUserClass> usermodel = new List<ModalUserClass>();
        public RegistrationLambda()
        {
            ModalUserClass modelUserClass = new ModalUserClass();
            usermodel.Add(modelUserClass);
        }
        public void FirstNames(string firstname)
        {
            if (usermodel.Any(x => x.FirstName.IsMatch(firstname)))
            {
                Console.WriteLine("Valid Pattern");
            }
            else
            {
                Console.WriteLine("Invalid Pattern");
            }
        }
        public void LastNames(string lastname)
        {
            if (usermodel.Any(x => x.LastName.IsMatch(lastname)))
            {
                Console.WriteLine(" Valid Pattern");
            }
            else
            {
                Console.WriteLine(" Invalid Pattern");
            }
        }
        public void Email(string email)
        {
            if (usermodel.Any(x => x.Email.IsMatch(email)))
            {
                Console.WriteLine(" Valid Pattern");
            }
            else
            {
                Console.WriteLine(" Invalid Pattern");
            }
        }
        public void PhoneNumbers(string phone)
        {
            if (usermodel.Any(x => x.PhoneNumber.IsMatch(phone)))
            {
                Console.WriteLine(" Valid Pattern");
            }
            else
            {
                Console.WriteLine(" Invalid Pattern");
            }
        }
        public void Passwords1(string password)
        {
            if (usermodel.Any(x => x.Password1.IsMatch(password)))
            {
                Console.WriteLine(" Valid Pattern");
            }
            else
            {
                Console.WriteLine(" Invalid Pattern");
            }
        }
        public void Passwords2(string password2)
        {
            if (usermodel.Any(x => x.Password2.IsMatch(password2)))
            {
                Console.WriteLine(" Valid Pattern");
            }
            else
            {
                Console.WriteLine(" Invalid Pattern");
            }
        }
        public void Passwords3(string password3)
        {
            if (usermodel.Any(x => x.Password3.IsMatch(password3)))
            {
                Console.WriteLine(" Valid Pattern");
            }
            else
            {
                Console.WriteLine(" Invalid Pattern");
            }
        }
    }
}
