using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Interfaces.InterfaceServices
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
        bool ClienteNaoAtivo(Cliente cliente);
        bool CadastroRepetido(Cliente cliente);

    }

  
}
