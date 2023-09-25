using System.ComponentModel.DataAnnotations;

namespace AvatarWebApi.Model.Entity
{
    public class Avatar
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string BIO {  get; set; } = string.Empty;
        public Guardian Guardian { get; set; } = new Guardian();
        public Clan Clan { get; set; } = new Clan();
        public List<Elemento> Elemento { get; set; } = new List<Elemento>();
        public List<Habilidades> Habilidades { get; set; } = new List<Habilidades>();
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaActualizacion { get; set; } = DateTime.Now;
        public int Estado { get; set; } = 1;

    }
}
