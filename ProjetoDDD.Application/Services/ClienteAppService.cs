using ProjetoDDD.Application.Interfaces;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Application.Services
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteAppService;

        public ClienteAppService(IClienteService clienteAppService)
            :base(clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        public bool CadastroRepetido(Cliente cliente)
        {
            return _clienteAppService.CadastroRepetido(cliente);
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteAppService.ObterClientesEspeciais();
        }

        public bool ClienteNaoAtivo(Cliente cliente)
        {
            return _clienteAppService.ClienteNaoAtivo(cliente);
        }

    }
}
