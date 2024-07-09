using AdapterPattern;
using AdapterPattern.Services.MailServices;
using System.Globalization;
using StepEmailService = StepMailService.StepMailService;


//IMailService mailService = new GmailSevice();
//ControlPanel cp = new(mailService);

StepEmailService stepService = new();
StepServiceToMailServiceAdapter adapter = new(stepService);
ControlPanel cp = new(adapter);
String

cp.Register();
cp.Checkout();