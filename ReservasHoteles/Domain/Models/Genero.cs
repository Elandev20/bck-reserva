using System.ComponentModel.DataAnnotations;

namespace ReservasHoteles.Domain.Models
{
    public class Genero
    {
        [Key]
        public int id { get; set; }

        public string descripcion { get; set; }

    }
}
