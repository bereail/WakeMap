using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GPS
    {
        public int Id { get; set; }

        public string Latitud { get; set; }

        public string Adress { get; set; }  

        public string ActivationRadius { get; set; }

        public bool Status { get; set; }
    }
}
