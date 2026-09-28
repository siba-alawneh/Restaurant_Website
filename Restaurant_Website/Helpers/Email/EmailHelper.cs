using MimeKit;
using MailKit.Net.Smtp;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Helpers.Email
{
    public class EmailHelper : IEmailHelper
    {
        public void SendMessage(EmailViewModel model)
        {
            //Email sending logic here

            var FromEmail = "YOUR EMAIL";
            var AppPassword = "YOUR PASSWORD";
            var SMTPServer = "smtp.gmail.com";
            var SMTPPort = 465;

            //Email Message

            var EmailMessage = new MimeMessage();
            EmailMessage.From.Add(new MailboxAddress("NAME", FromEmail));
            EmailMessage.To.Add(MailboxAddress.Parse(model.EmailAddress));
            EmailMessage.Subject = model.Subject;
            EmailMessage.Body = new TextPart("plain") { Text = model.Message };

            //Send Email
            var client = new SmtpClient();
            client.Connect(SMTPServer, SMTPPort, MailKit.Security.SecureSocketOptions.SslOnConnect);
            client.Authenticate(FromEmail, AppPassword);
            client.Send(EmailMessage);
            client.Disconnect(true);

        }

       
    }
}
