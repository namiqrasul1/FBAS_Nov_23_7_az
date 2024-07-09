using AdapterPattern.Services.MailServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class ControlPanel
    {
        private readonly IMailService _mailService;
        // User user;

        public ControlPanel(IMailService mailService)
        {
            _mailService = mailService;
        }

        public void Register()
        {
            _mailService.ConfirmMail("user@mail.com", "ashdjkashdjkas");
        }

        public void Checkout()
        {
            // hesablama
            // odenish strategiya
            _mailService.SendMail("user@mail.com", "alish-verish hesabati", "invoice");
        }
    }
}
