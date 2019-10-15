namespace ProjetoDDD.UI.ViewModels
{
    public class ProdutoViewModel
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }
        public ClienteViewModel cliente { get; set; }
    }
}