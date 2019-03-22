using System;
using System.Text;

namespace Carplar.Shop.Diagnostics
{
    public class DiagnosticsEmail : CarplarEmail
    {
        public void Send(string subject, Exception e = null)
        {
            AddSubject(subject);

            AddTo("milan@carplar.com");

            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(subject);
            stringBuilder.AppendLine("<br />");

            if (e != null)
            {
                stringBuilder.AppendLine("-----------------------------");
                stringBuilder.AppendLine("<br />");
                stringBuilder.AppendLine("Exception Stack Trace");
                stringBuilder.AppendLine("<br />");

                while (e != null)
                {
                    stringBuilder.AppendLine(e.Message);
                    stringBuilder.AppendLine("<br />");
                    stringBuilder.AppendLine(e.StackTrace);
                    stringBuilder.AppendLine("<br />");

                    e = e.InnerException;
                }
            }

            stringBuilder.AppendLine("-----------------------------");
            stringBuilder.AppendLine("<br />");

            stringBuilder.AppendLine("Carplar Diagnostics Email");

            AddBody(stringBuilder.ToString());

            Send();
        }
    }
}