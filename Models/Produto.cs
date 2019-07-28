namespace CadastroProduto.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public double Quantidade { get; set; }
        public bool Estado { get; set; }

    }
}