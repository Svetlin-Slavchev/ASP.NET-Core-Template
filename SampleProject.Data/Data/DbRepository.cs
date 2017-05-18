using Microsoft.EntityFrameworkCore;
using SampleProject.Abstraction.Data;
using SampleProject.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleProject.Data.Data
{
    public class DbRepository<T> : IDbRepository<T>
        where T : class, IDeletableEntity
    {
        public DbRepository(IApplicationDbContext context)
        {
            this.Context = context ?? throw new ArgumentException("An instance of DbContext is required to use this repository.", nameof(context));
            this.DbSet = this.Context.Set<T>();
        }

        private DbSet<T> DbSet { get; }

        private IApplicationDbContext Context { get; }

        public IQueryable<T> All()
        {
            return this.DbSet.Where(x => !x.IsDeleted);
        }

        public IQueryable<T> AllWithDeleted()
        {
            return this.DbSet;
        }

        public T GetById(object id)
        {
            var item = this.DbSet.Find(id);
            if (item.IsDeleted)
            {
                return null;
            }

            return item;
        }

        public void Add(T entity)
        {
            this.DbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.Now;
        }

        public void HardDelete(T entity)
        {
            this.DbSet.Remove(entity);
        }

        public void Save()
        {
            this.Context.SaveChanges();
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }
    }
}
