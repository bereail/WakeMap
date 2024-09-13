using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Notification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Alarm")]
        public int AlarmId { get; set; }  // Relación con la alarma
        public Alarm Alarm { get; set; }  // Propiedad de navegación

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }  // Tipo de notificación (ej: email, push)

        [Required]
        [MaxLength(500)]
        public string Message { get; set; }  // Mensaje de la notificación

        [Required]
        public DateTime SentAt { get; set; }  // Fecha y hora en que fue enviada

        public DateTime? ReadAt { get; set; }  // Fecha y hora en que fue leída (puede ser null)
    }
}
