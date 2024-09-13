using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }  // Nombre de usuario

        [Required]
        [EmailAddress]
        public string Email { get; set; }  // Correo electrónico del usuario

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }  // Contraseña del usuario

        [Required]
        public int Tel { get; set; }  // Teléfono del usuario

        public string UserSettings { get; set; }  // Ajustes personalizados del usuario (JSON o XML)

        public int Status { get; set; }  // Estado del usuario (activo, inactivo, etc.)

        public ICollection<Alarm> Alarms { get; set; }  // Relación con Alarmas
    }
}