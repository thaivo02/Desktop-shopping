﻿using Sneakerz.Entity;

namespace Sneakerz.Repository;

public interface IRepository<TEntity, TKey>
    where TEntity : AggressiveRoot<TKey>
{
    int SaveChanges();
    
    IQueryable<TEntity> GetAll();

    void Add(TEntity entity);
        
    void Update(TEntity entity);

    void Delete(TEntity entity);
}