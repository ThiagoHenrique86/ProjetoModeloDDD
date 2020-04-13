using System;
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;


namespace ProjetoModeloDDD.Domain.Services
{
    public class ServiceBase<TEnity> : IDisposable, IServiceBase<TEnity> where TEnity : class
    {
        private readonly IRepositoryBase<TEnity> _repository;

        public ServiceBase(IRepositoryBase<TEnity> repository)
        {
            _repository = repository;
        }

        public void Add(TEnity obj)
        {
            _repository.Add(obj);
        }


        public TEnity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEnity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEnity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEnity obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

    }
}
