namespace AvatarWebApi.Model.Entity
{
    public class Especiales
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public Elemento Elemento { get; set; } = new Elemento();
        public int Rango { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaActualizacion { get; set; } = DateTime.Now;
        public int Estado { get; set; } = 1;
    }
}
