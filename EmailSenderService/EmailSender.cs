using System.Net;
using System.Net.Mail;

namespace EmailSendingApp.EmailSenderService
{
    public class EmailSender: IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SmtpClient("SMTP Server Link", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("Email of SMTP Server", "Password of SMTP Server")
            };

            return client.SendMailAsync(
                new MailMessage(
                    from: "Email",
                    to: email, 
                    subject,
                    message
                ));
        }
    }
}
