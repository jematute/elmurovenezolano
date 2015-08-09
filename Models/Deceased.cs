using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElMuroVenezolano.Models
{
    public class Deceased
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string deceasedCity { get; set; }
        public string deceasedState { get; set; }
        public DateTime deceasedDate { get; set; }
        public string bornCity { get; set; }
        public string bornState { get; set; }
        public string decription { get; set; }
    }
}