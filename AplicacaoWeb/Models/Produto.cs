namespace AplicacaoWeb.Models
{
    public class Produto
    {
        protected int id;
        protected string nome;
        protected double valor;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
