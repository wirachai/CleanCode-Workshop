using System.Net.Mail;

namespace CleanCodeWorkshop._3._Extracting_Parameter_Object
{
    public class EmailSender
    {
        public EmailConfiguration Configure { get; set; }
        public EmailSender(EmailConfiguration configure)
        {
            Configure = configure;
        }
        public void SendMessage(EmailMessage email)
        {
            using (SmtpClient client = new SmtpClient(Configure.HostName, Configure.HostPort))
            {
                MailMessage message = new MailMessage(email.From, email.To);
                message.Subject = email.Subject;
                message.Body = email.Body;
                client.Send(message);
            }
        }
    }

    public class EmailConfiguration
    {
        public string HostName { get; set; }
        public int HostPort { get; set; }
    }

    public class EmailMessage
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}