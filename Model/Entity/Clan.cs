namespace AvatarWebApi.Model.Entity
{
    public class Clan
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string BIO { get; set; } = string.Empty;
        public List<Especiales> Especiales { get; set; } = new List<Especiales>(); 
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaActualizacion {  get; set; } = DateTime.Now;
        public int Estado { get; set; } = 1;
    }
}
