using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.InterfaceServices;
using ProjetoDDD.Domain.Interfaces.RepositoriesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private IProdutoRepositoryBase _produtoRepository;

        public ProdutoService(IProdutoRepositoryBase produtoRepository)
            :base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
