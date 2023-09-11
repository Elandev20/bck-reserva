using System.ComponentModel.DataAnnotations;

namespace ReservasHoteles.Domain.Models
{
    public class Ciudad
    {
        [Key]
        public int CiudadId { get; set; }

        public string CiudadNombre { get; set; }

        public string PaisCodigo { get; set; }

        public string CiudadDistrito { get; set; }

        public int CiudadPoblacion { get; set; }
    }
}
