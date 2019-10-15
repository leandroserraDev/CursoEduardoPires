using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Entities
{
   public class Cliente
    {
        public Cliente(string nome, string sobrenome, string email, bool ativo, int produtoId)
        {

            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            DataCadastro = DateTime.Now;
            Ativo = ativo;
            ProdutoId = produtoId;
        }

        public Cliente() { }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public int ProdutoId { get; set; }
        public  IEnumerable<Produto> Produtos { get; set; }


        public bool ClienteEspecial(Cliente cliente)
        {

            return cliente.Ativo && cliente.DataCadastro.Year - DateTime.Now.Year >= 5;
         
        }


    }
}
