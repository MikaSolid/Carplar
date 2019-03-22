using System.Net.Mail;

namespace Carplar.Shop.Utilities
{
    public class Mailer
    {
        public Mailer()
        {
        }

        public bool Send(MailMessage message)
        {
            using (var smtpClient = new SmtpClient())
            {
                try
                {
                    smtpClient.Send(message);
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }
    }
}