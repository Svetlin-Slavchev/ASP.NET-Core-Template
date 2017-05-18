using SampleProject.Entities.Abstraction;
using System.ComponentModel.DataAnnotations;

namespace SampleProject.Entities
{
    public class TestEFEntity : BasеEntity<int>
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
