using System.Net;
using System.Net.Mail;

namespace EmailSendingApp.EmailSenderService
{
    public class EmailSender: IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SmtpClient("smtp-relay.brevo.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("musmanch2004@gmail.com", "4Ga0AbVxrfIzEUcs")
            };

            return client.SendMailAsync(
                new MailMessage(
                    from: "musmanch2004@gmail.com",
                    to: email, 
                    subject,
                    message
                ));
        }
    }
}
