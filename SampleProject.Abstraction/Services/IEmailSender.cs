using System.Threading.Tasks;

namespace SampleProject.Abstraction.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
