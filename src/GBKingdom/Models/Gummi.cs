using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GBKingdom.Models
{
    [Table("Gummies")]
    public class Gummi
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public decimal cost { get; set; }
        public string originCountry { get; set; }
    }
}
