namespace CarpinteriaArtesanal.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string elaborado { get; set; }
        public string categoria { get; set; }
        public string descripcion { get; set; }
        public string alto { get; set; }
        public string largo { get; set; }
        public string profundidad { get; set; }
        public string precio { get; set; }
        public bool destacado { get; set; }
        public bool activo { get; set; }

    }
}
