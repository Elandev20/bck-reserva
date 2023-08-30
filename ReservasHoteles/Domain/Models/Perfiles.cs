using System.ComponentModel.DataAnnotations;

namespace ReservasHoteles.Domain.Models
{
    public class Perfiles
    {
        [Key]
        public int idPerfil { get; set; }

        public string descripcion { get; set; }
    }
}
