using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public int AlarmId { get; set; }
        public int UserId { get; set; }
        public string type { get; set; }

        public string Message { get; set; } 
        
        public string SentAt { get; set; } 
    }
}
