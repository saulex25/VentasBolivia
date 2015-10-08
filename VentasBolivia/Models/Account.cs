using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentasBolivia.Models
{
    public class Account : EntityBase
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Ci { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}