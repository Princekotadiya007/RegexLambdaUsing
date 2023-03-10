using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexLambda
{
    public class ModalUserClass
    {
        public Regex FirstName = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex LastName = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex PhoneNumber = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex Email = new Regex(@"^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$");
        public Regex Password1 = new Regex(@"[A-Z]{1}[a-z0-9]");
        public Regex Password2 = new Regex(@"(?=.*[A-Z])[A-Za-z0-9]{8,}");
        public Regex Password3 = new Regex(@"(?=.[A-Z])(?=.[0-9])[A-Za-z0-9]{8,}");
        public Regex Password4 = new Regex(@"(?=.[A-Z])(?=.[0-9])(?=.[#@$!^_-])[A-Za-z0-9]{8,}");
        public Regex SimpelEmail = new Regex(@"^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$");
    }
}
