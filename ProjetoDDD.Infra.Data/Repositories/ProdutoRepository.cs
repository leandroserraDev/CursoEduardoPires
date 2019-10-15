using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.RepositoriesInterfaces;
using ProjetoDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepositoryBase
    {
      public ProdutoRepository(ProjetoContext context)
            :base(context)
        { }
    }
}
