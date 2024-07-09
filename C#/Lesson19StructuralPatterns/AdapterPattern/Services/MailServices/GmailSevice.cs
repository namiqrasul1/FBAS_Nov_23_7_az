using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Services.MailServices
{
    internal class GmailSevice : IMailService
    {
        public bool CheckValidMail(string email)
        {
            Console.WriteLine("Gmail maili yoxladi");
            return true;
        }

        public void ConfirmMail(string email, string token)
        {
            // tesdiq maili gonderme alqoritmi
            Console.WriteLine("Gmail tesdiq mailini gonderdi");
        }

        public void SendMail(string to, string subject, string body)
        {
            Console.WriteLine("Gmail maili gonderdi");
        }
    }
}
