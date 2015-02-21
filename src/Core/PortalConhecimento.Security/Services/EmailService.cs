using Microsoft.AspNet.Identity;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Web;

namespace PortalConhecimento.Security.Services
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            return Task.Factory.StartNew(() =>
            {
                this.Send(message);
            });
        }

        private void Send(IdentityMessage message)
        {
            var plainText = string.Format("Copie e cole o seguinte link para {0}: {1}", message.Subject, message.Body);
            string htmlText = "Confirme sua conta clicando neste link: <a href=\"" + message.Body + "\">link</a><br/>";
            htmlText += HttpUtility.HtmlEncode(@" ou copie e cole o seguinte link no seu navegador:" + message.Body);
            using (var smtpClient = new SmtpClient())
            {
                using (var mailMessage = new MailMessage())
                {
                    mailMessage.To.Add(message.Destination);
                    mailMessage.Subject = message.Subject;
                    mailMessage.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(plainText, null, MediaTypeNames.Text.Plain));
                    mailMessage.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(htmlText, null, MediaTypeNames.Text.Html));
                    smtpClient.Send(mailMessage);
                }
            }
        }
    }
}