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
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepositoryBase _clienteRepository;

        public ClienteService(IClienteRepositoryBase clienteRepository)
            :base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public bool CadastroRepetido(Cliente cliente)
        {
            var clienteNovo = cliente.Email.ToUpper();
            var clientesBanco = _clienteRepository.ObterTodos().Where(x => x.Email.ToUpper() == clienteNovo);

            if (clientesBanco.Count() > 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool ClienteNaoAtivo(Cliente cliente)
        {
            if (!cliente.Ativo)
            {
                return true;
            }
            else
                return false;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteRepository.ObterTodos().Where(x => x.ClienteEspecial(x));
        }

    }
}
