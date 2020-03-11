using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace banger.Models
{
    public class Vehicle
    {
        [Key]
        public string VehicleNo { get; set; }
        [Required(ErrorMessage = "Theis Field is Required")]
        public string VehicleType { get; set; }
        [Required(ErrorMessage = "Theis Field is Required")]
        public float Amount { get; set; }

        public bool VehicleAvailability { get; set; }

        public string Pic { get; set; }

        public int Doors { get; set; }

        public string GearBox { get; set; }

        public string Facilities { get; set; }

        public string FuelType { get; set; }

        public string Class { get; set; }



    }
}
