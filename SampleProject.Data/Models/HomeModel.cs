using SampleProject.Abstraction.Models;

namespace SampleProject.Data.Models
{
    public class HomeModel : IHomeModel
    {
        public string Name { get; set; }
        public int Years { get; set; }
    }
}
