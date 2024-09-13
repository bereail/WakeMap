using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GPS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public double Latitude { get; set; }  // Latitud del GPS

        [Required]
        public double Longitude { get; set; }  // Longitud del GPS

        [Required]
        [MaxLength(255)]
        public string Address { get; set; }  // Dirección asociada al GPS

        [Required]
        public double ActivationRadius { get; set; }  // Radio de activación en metros

        public bool Status { get; set; }  // Estado del GPS (activo/inactivo)

        [Required]
        public DateTime UpdatedAt { get; set; }  // Fecha de última actualización
    }
}
