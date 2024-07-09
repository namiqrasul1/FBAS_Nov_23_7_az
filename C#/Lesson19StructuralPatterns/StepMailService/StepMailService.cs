using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepMailService
{
    public class StepMailService
    {
        public bool StepCheckValidMail(string email)
        {
            Console.WriteLine("StepMailService maili yoxladi");
            return true;
        }

        public void StepConfirmMail(string email, string token)
        {
            // tesdiq maili gonderme alqoritmi
            Console.WriteLine("StepMailService tesdiq mailini gonderdi");
        }

        public void StepSendMail(string to, string subject, string body)
        {
            Console.WriteLine("StepMailService maili gonderdi");
        }
    }
}
