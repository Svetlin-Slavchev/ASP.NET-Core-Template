using System;
using System.ComponentModel.DataAnnotations;

namespace SampleProject.Entities.Abstraction
{
    public abstract class DeletableEntity : IDeletableEntity
    {
        [Editable(false)]
        public bool IsDeleted { get; set; }

        [Editable(false)]
        [DataType(DataType.DateTime)]
        public DateTime? DeletedOn { get; set; }
    }
}
