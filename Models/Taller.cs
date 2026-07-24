namespace CarpinteriaArtesanal.Models
{
    public class Taller
    {
        public int id { get; set; }
        public string nombretaller { get; set; }
        public string dictado { get; set; }
        public string duracion { get; set; }
        public string materiales { get; set; }
        public string precio { get; set; }
        public bool activo { get; set; }

    }
}
