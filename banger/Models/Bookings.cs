using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace banger.Models
{
    public class Bookings
    {
   [Key]
        public int BookingID { get; set; }

        public string BookingStatus { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime PickUpDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime ReturnDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage ="Theis Field is Required")]
        public string VehicleNo { get; set; }

        public string Email { get; set; }

        public string Pic { get; set; }

        public string PicExtra { get; set; }
        public string Equipment { get; set; }
        [Required(ErrorMessage = "Theis Field is Required")]
        public string LicenseNo { get; set; }

        public string NICNo { get; set; }

        public float Amount { get; set; }

    }
}
