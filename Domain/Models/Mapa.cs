namespace Domain.Models
{
    public class Mapa
    {
        public int Id_mapa { get; set; }
        public string Nome_mapa { get; set; }
        public string Localizacao { get; set; }
        public string Tamanho { get; set; }
        public string Layout { get; set; }    
        public string Lado_favorito { get; set; }
        public string Descricao { get; set; }
        public string Imagem_mapa { get; set; }
    }
}
