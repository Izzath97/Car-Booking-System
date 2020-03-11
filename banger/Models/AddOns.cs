using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace banger.Models
{
    public class AddOns
    {
        [Key]
        public int AddOnsID { get; set; }
        public string Equipment { get; set; }

        public bool Availability { get; set; }

        public float Amount { get; set; }

        public int Quantity { get; set; }

    }
}
