using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ActivationCondition
    {
        public int Id { get; set; }

        public string ConditionType {  get; set; }

        public string Threshold { get; set; }

        public string LocationCondition { get; set; }

    }
}
