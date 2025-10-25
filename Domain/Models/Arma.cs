namespace Domain.Models
{
    public class Arma
    {
        public int Id_arma { get; set; }
        public string Nome_arma { get; set; }
        public string Tipo { get; set; }
        public int Dano { get; set; }
        public int Precisao { get; set; }
        public int Cadencia { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string Imagem_arma { get; set; }
    }
}
