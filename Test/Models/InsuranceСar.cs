using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class InsuranceСar
    {
        public int Id { get; set; }
     //   [Required(ErrorMessage = "Invalid name")]

        public string NSF { get; set; }

      //  [EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; }

       // [RegularExpression(@"/ ^\0\d{3}\d{2}\d{2}\d{2}$/")]
        public string Phone { get; set; }

        public string City { get; set; }
      
        public string ModelCar { get; set; }

        public string CarYear { get; set; }

    }
}
