using Carplar.Shop.Utilities;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace Carplar.Shop.Diagnostics
{
    public class CarplarEmail
    {
        protected readonly MailMessage _mail = new MailMessage();
        protected readonly Mailer _mailer = new Mailer();

        public CarplarEmail()
        {
            _mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            _mail.SubjectEncoding = UTF8Encoding.UTF8;
            _mail.BodyEncoding = UTF8Encoding.UTF8;
            _mail.IsBodyHtml = true;
        }

        public CarplarEmail AddSubject(string subject)
        {
            _mail.Subject = subject;
            return this;
        }

        public CarplarEmail AddBody(string body)
        {
            _mail.Body = body;
            return this;
        }

        public CarplarEmail AddTo(string to)
        {
            _mail.To.Add(new MailAddress(to));
            return this;
        }

        public CarplarEmail AddCc(string cc)
        {
            _mail.CC.Add(new MailAddress(cc));
            return this;
        }

        public CarplarEmail AddCc(IEnumerable<string> ccs)
        {
            foreach (var cc in ccs)
            {
                _mail.CC.Add(new MailAddress(cc));
            }

            return this;
        }

        public CarplarEmail AddAttachment(string fileName)
        {
            _mail.Attachments.Add(new Attachment(fileName));
            return this;
        }

        public bool Send()
        {
            if (_mail.To == null)
            {
                throw new InvalidOperationException("'To' field must be defined");
            }

            return _mailer.Send(_mail);
        }

        private AlternateView GetEmbededResource(string filePath)
        {
            var resource = new LinkedResource(filePath);

            var alternateView = AlternateView.CreateAlternateViewFromString(
                string.Format(@"<img src='cid:{0}'/>", resource.ContentId),
                null,
                MediaTypeNames.Text.Html);

            alternateView.LinkedResources.Add(resource);

            return alternateView;
        }
    }
}