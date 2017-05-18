using SampleProject.Abstraction.Models;
using SampleProject.Abstraction.Services;
using SampleProject.Data.Models;

namespace SampleProject.Data.Services
{
    public class HomeService : IHomeService
    {
        public IHomeModel GetModel()
        {
            return new HomeModel()
            {
                Name = "test",
                Years = 1
            };
        }
    }
}
