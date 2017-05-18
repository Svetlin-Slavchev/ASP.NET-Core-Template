using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SampleProject.Entities;
using System;

namespace SampleProject.Abstraction.Data
{
    public interface IApplicationDbContext : IDisposable
    {
        DbSet<TestEFEntity> TestEFEntity { get; set; }
        DbSet<TestEFEntityTwo> TestEFEntityTwo { get; set; }

        int SaveChanges();

        void ClearDatabase();

        EntityEntry<TEntity> Entry<TEntity>(TEntity entity)
            where TEntity : class;

        DbSet<T> Set<T>()
            where T : class;
    }
}
