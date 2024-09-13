using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserSettings
    {
        [Key]
        [ForeignKey("User")]
        public int UserId { get; set; }  // Relación con el usuario

        public User User { get; set; }  // Propiedad de navegación

        public bool EnableSound { get; set; }  // Ajuste de sonido habilitado/deshabilitado

        public bool EnableVibration { get; set; }  // Ajuste de vibración habilitado/deshabilitado

       
    }
}
