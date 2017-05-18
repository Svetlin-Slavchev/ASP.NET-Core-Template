using SampleProject.Entities.Abstraction;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleProject.Entities
{
    public class TestEFEntityTwo : BasеEntity<int>
    {
        public string Name { get; set; }

        [ForeignKey("TestEFEntity")]
        public int? TestEFEntityId { get; set; }

        public virtual TestEFEntity TestEFEntity { get; set; }
    }
}
