namespace EmailSendingApp.EmailSenderService
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
