using System.Threading.Tasks;

namespace SampleProject.Abstraction.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
