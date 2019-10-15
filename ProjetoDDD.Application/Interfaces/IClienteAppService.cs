using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Application.Interfaces
{
   public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
        bool ClienteNaoAtivo(Cliente cliente);
        bool CadastroRepetido(Cliente cliente);
    }
}
