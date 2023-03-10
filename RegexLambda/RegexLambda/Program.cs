using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexLambda
{
    public class Program
    {
        static void Main(string[] args)
        {
            RegistrationLambda userlambda = new RegistrationLambda();
            userlambda.FirstNames("Prince");
            userlambda.LastNames("Kotadiya");
            userlambda.Email("abc.xyz@prince.co.in");
            userlambda.PhoneNumbers("91 6352129268");
            userlambda.Password("Princes7");
            Console.ReadLine(); 
        }
    }
}
