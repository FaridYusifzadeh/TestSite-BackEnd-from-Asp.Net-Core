using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Polo.Models
{
    public class OurWork
    {
        public int Id { get; set; }
        [Required,StringLength(250)]
        public string Image { get; set; }
       
    }
}
