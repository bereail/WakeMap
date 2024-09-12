using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Alarm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Hour { get; set; }
        public bool Repeat { get; set; }
        public string Tono { get; set; }

        public bool status { get; set; }
        public bool Vibration { get; set; }
        public string PersonalizeMessage { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
