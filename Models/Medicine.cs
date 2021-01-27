using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Pharma.Models
{
    public class Medicine
    {
        public int ID { get; set; }

        [Display(Name = "Medicine name")]
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

    }
}
