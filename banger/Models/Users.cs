using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace banger.Models
{
    public class Users
    {


        public const string SessionKeyName = "email";
        [Required(ErrorMessage = "Theis Field is Required")]
        public string Name { get; set; }

        public int Age { get; set; }


        public string Gender { get; set; }

        public int ContactNumber { get; set; }


        public string Address { get; set; }


        public String Pic { get; set; }

        [Key]
        public string Email { get; set; }

        public string Password { get; set; }

        public string Type { get; set; }


      
        public string Status { get; set; }


    }
}
