using System.Net.Mail;

namespace CleanCodeWorkshop._3._Extracting_Parameter_Object
{
    public class EmailSender
    {
        public void SendMessage(string sendFrom, string sendTo, string subject, string body, string hostName, int hostPort)
        {
            using (SmtpClient client = new SmtpClient(hostName, hostPort))
            {
                MailMessage message = new MailMessage(sendFrom, sendTo);
                message.Subject = subject;
                message.Body = body;
                client.Send(message);
            }
        }
    }
}