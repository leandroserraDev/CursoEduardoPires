using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoDDD.UI.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
       
        }

        [Key]
        public int ClienteId { get; set; }

        [Display(Name ="Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Sobrenome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        [Display(Name = "Data Cadastro")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Ativo")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public bool Ativo { get; set; }

        [Display(Name = "Produto ID")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int ProdutoId { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
         


    }
}