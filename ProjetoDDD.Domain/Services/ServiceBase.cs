using ProjetoDDD.Domain.Interfaces.InterfaceServices;
using ProjetoDDD.Domain.Interfaces.RepositoriesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Add(TEntity obj)
        {
            _repositoryBase.Add(obj);
        }

        public void Delete(TEntity obj)
        {
            _repositoryBase.Delete(obj);
        }

        public TEntity ObterPoId(int id)
        {
            return _repositoryBase.ObterPorId(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _repositoryBase.ObterTodos();
        }

        public void Update(TEntity obj)
        {
            _repositoryBase.Update(obj);
        }
    }
}
