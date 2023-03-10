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
    }
}
