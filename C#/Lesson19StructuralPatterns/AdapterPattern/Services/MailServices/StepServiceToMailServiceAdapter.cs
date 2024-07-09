using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Services.MailServices
{
    internal class StepServiceToMailServiceAdapter : IMailService
    {
        private readonly StepMailService.StepMailService stepMailService;

        public StepServiceToMailServiceAdapter(StepMailService.StepMailService stepMailService)
        {
            this.stepMailService = stepMailService;
        }

        public bool CheckValidMail(string email)
        {
            return stepMailService.StepCheckValidMail(email);
        }

        public void ConfirmMail(string email, string token)
        {
            stepMailService.StepConfirmMail(email, token);
        }

        public void SendMail(string to, string subject, string body)
        {
            stepMailService.StepSendMail(to, subject, body);
        }
    }
}
