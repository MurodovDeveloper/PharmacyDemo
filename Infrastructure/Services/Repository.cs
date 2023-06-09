﻿using Application.Abstraction;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private IApplicatonDbcontext _db;

        public Repository(IApplicatonDbcontext db)
        {
            _db = db;
        }

        public async Task<ICollection<T>> AddRangeAsync(ICollection<T> entities)
        {

            await _db.Set<T>().AddRangeAsync(entities);
            await _db.SaveChangesAsync();
            return entities;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> expression)
        {
            List<T> entities = _db.Set<T>().Where(expression).ToList();
            await _db.SaveChangesAsync();
            return entities;
        }

        public async Task<T> Get(Guid Id)
        {
            T? result = await _db.Set<T>().FindAsync(Id)!;
            return result!;
        }
        public Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}