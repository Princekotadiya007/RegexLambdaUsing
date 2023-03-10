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
        public Lambda()
        {
            ModalUserClass modelUserClass = new ModalUserClass();
            usermodel.Add(modelUserClass);
        }
        public void CheckFirstNmae(string firstname)
        {
            if (usermodel.Any(x => x.FirstName.IsMatch(firstname)))
            {
                Console.WriteLine("It is A Valid Pattern");
            }
            else
            {
                Console.WriteLine("Not a VAlid Pattern");
            }
        }
    }
}
