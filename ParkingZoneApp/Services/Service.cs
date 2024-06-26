﻿
using ParkingZoneApp.Repositories;

namespace ParkingZoneApp.Services;

public class Service<T> : IService<T> where T : class
{
    private readonly IRepository<T> _repository;
    public Service(IRepository<T> repository)
    {
        _repository = repository;
    }
    public void Delete(T entity)
    {
        _repository.Delete(entity);
    }

    public IEnumerable<T> GetAll()
    {
        return _repository.GetAll();
    }

    public T GetById(int? Id)
    {
        return _repository.GetById(Id);
    }

    public void Insert(T entity)
    {
        _repository.Insert(entity);
    }

    public void Update(T entity)
    {
        _repository.Update(entity);
    }
}
