using SampleProject.Entities;

namespace SampleProject.Abstraction.Data
{
    public interface ISampleProjectData
    {
        IApplicationDbContext ApplicationDbContext { get; set; }
        IDbRepository<TestEFEntity> TestEFEntitiesRepository { get; set; }
    }
}
