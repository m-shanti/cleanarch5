using System.Threading.Tasks;

namespace cleanarch5.Core.Interfaces;

public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}
