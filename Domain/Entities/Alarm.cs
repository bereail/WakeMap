using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Alarm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }  // Nombre de la alarma

        [Required]
        public DateTime Hour { get; set; }  // Hora en la que la alarma está programada

        public bool Repeat { get; set; }  // Si la alarma se repite

        [MaxLength(255)]
        public string Tono { get; set; }  // Tono de la alarma

        public bool Status { get; set; }  // Estado de la alarma (activada o no)

        public bool Vibration { get; set; }  // Si la alarma usa vibración

        [MaxLength(500)]
        public string PersonalizeMessage { get; set; }  // Mensaje personalizado

        [ForeignKey("User")]
        public int UserId { get; set; }  // Relación con el usuario que creó la alarma
        public User User { get; set; }  // Propiedad de navegación

        [ForeignKey("ActivationCondition")]
        public int ConditionId { get; set; }  // Relación con condiciones de activación
        public ActivationCondition Condition { get; set; }  // Propiedad de navegación

        public ICollection<AlarmHistory> AlarmHistories { get; set; }  // Historial de la alarma
    }
}
