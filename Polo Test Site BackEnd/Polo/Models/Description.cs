using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Polo.Models
{
    public class Description
    {
        public int Id { get; set; }

        [Required,StringLength(150)]
        public string Title { get; set; }

        [Required, StringLength(350)]
        public string Descp { get; set; }

    }
}
