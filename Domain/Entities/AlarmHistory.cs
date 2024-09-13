using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AlarmHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Alarm")]
        public int AlarmId { get; set; }  // Relación con la alarma
        public Alarm Alarm { get; set; }  // Propiedad de navegación

        [Required]
        public DateTime ActivationTimestamp { get; set; }  // Fecha y hora de activación de la alarma

        public DateTime TriggeredAt { get; set; }  // Fecha y hora en que se notificó al usuario

        public bool Acknowledged { get; set; }  // Si el usuario reconoció la alarma

        [MaxLength(255)]
        public string Location { get; set; }  // Ubicación donde se activó la alarma

        [MaxLength(255)]
        public string Outcome { get; set; }  // Resultado de la activación (ej: ignorada, reconocida)
    }
}
