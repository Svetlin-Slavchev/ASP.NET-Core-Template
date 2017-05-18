using SampleProject.Abstraction.Data;
using SampleProject.Abstraction.Services;
using SampleProject.Entities;

namespace SampleProject.Data.Data
{
    public class SampleProjectData : ISampleProjectData
    {
        public SampleProjectData(IApplicationDbContext context, IHomeService homeService)
        {
            this.ApplicationDbContext = context;
            this.TestEFEntitiesRepository = new DbRepository<TestEFEntity>(context);
        }

        public IApplicationDbContext ApplicationDbContext { get; set; }
        public IDbRepository<TestEFEntity> TestEFEntitiesRepository { get; set; }
    }
}
