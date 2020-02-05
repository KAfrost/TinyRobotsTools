using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TinyRobotsTools.Models
{
    public class Order
    {

        public int Id { get; set; }

        [Required]
        public string Owner { get; set; }

        [Required]
        public CupSize CupSize { get; set; }

        [Required]
        public CupStyle CupStyle { get; set; }

        [Required]
        public GlitterName GlitterName { get; set; }

        [Required]
        public Status? Status { get; set; }
    }
}
