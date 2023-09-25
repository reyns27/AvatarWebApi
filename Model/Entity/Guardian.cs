namespace AvatarWebApi.Model.Entity
{
    public class Guardian
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion {  get; set; } = string.Empty;    
        public string Origen { get; set; } = string.Empty;
        public List<Elemento> Elemento { get; set; } = new List<Elemento>();
        public List<Habilidades> Habilidades { get; set;} = new List<Habilidades>();
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaActualizacion { get; set; } = DateTime.Now;
        public int Estado { get; set; } = 1;
    }
}
