using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Interfaces.InterfaceServices
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterPoId(int id);
        void Delete(TEntity obj);
        void Update(TEntity obj);

    }
}
