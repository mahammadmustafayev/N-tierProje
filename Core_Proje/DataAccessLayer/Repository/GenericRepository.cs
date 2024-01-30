﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repository;

public class GenericRepository<T> : IGeneric<T> where T : class
{
    public void Delete(T entity)
    {
        using var context = new Context();
        context.Remove(entity);
        context.SaveChanges();

    }

    public T GetById(int id)
    {
        using var context = new Context();
        return context.Set<T>().Find(id);
    }

    public List<T> GetList()
    {
        using var context = new Context();
        return context.Set<T>().ToList();
    }

    public void Insert(T entity)
    {
        using var context = new Context();
        context.Add(entity);
        context.SaveChanges();
    }

    public void Update(T entity)
    {
        using var context = new Context();
        context.Update(entity);
        context.SaveChanges();
    }
}
