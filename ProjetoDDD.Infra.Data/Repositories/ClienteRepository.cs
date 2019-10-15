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
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepositoryBase
    {
        public ClienteRepository(ProjetoContext context)
            :base(context)
        { }
    }
}
