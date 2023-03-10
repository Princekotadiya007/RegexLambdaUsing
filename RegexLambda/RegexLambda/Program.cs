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
            Console.ReadLine(); 
        }
    }
}
