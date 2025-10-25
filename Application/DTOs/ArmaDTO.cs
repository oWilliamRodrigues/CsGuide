namespace Application.DTOs
{
    public class ArmaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Dano { get; set; }
        public int Precisao { get; set; }
        public int Cadencia { get; set; }
        public decimal Preco{ get; set; }
        public string Descricao { get; set; }
        public string ImagemUrl { get; set; }
    }
}
