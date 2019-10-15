using ProjetoDDD.Application.Interfaces;
using ProjetoDDD.Domain.Interfaces.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Application.Services
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Delete(TEntity obj)
        {
            _serviceBase.Delete(obj);
        }

        public TEntity ObterPorId(int id)
        {
            return _serviceBase.ObterPoId(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _serviceBase.ObterTodos();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }
    }
}
