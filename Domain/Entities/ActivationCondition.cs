using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ActivationCondition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ConditionType { get; set; }  // Tipo de condición (ej: ubicación, proximidad)

        [Required]
        public string ConditionData { get; set; }  // Datos de la condición (puede ser un JSON o XML)

        [MaxLength(100)]
        public string Threshold { get; set; }  // Umbral para activar la alarma (distancia, tiempo, etc.)

        [ForeignKey("GPS")]
        public int GpsId { get; set; }  // Relación con los datos de GPS
        public GPS Gps { get; set; }  // Propiedad de navegación
    }
}
