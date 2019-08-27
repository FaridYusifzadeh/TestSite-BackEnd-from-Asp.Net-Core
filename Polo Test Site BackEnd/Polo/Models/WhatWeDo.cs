using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Polo.Models
{
    public class WhatWeDo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="This input required."),StringLength(100,ErrorMessage ="Simbol count few than 100")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This input required."), StringLength(400, ErrorMessage = "Simbol count few than 100")]
        public string Description { get; set; }
    }
}
