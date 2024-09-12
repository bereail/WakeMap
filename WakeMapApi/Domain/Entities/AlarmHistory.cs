using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AlarmHistory
    {
        public int Id { get; set; } 
        public int AlarmId { get; set; }
        public int ActivationTimeStame { get; set; }
        public string Location { get; set; }

        public string Outcome { get; set; }
    }
}
