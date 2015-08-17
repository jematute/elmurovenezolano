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
        public string Identification { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public City DeathCity { get; set; }
        public State DeathState { get; set; }
        public DateTime DeathDate { get; set; }
        public City BirthCity { get; set; }
        public State BirthState { get; set; }
        public Contact EnteredBy { get; set; }
        public string Information { get; set; }
    }
}