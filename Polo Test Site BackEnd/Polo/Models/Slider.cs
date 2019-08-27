using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Polo.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bos Saxlamayin"), StringLength(150,ErrorMessage ="Limiti kecdiz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bos Saxlamayin"), StringLength(400, ErrorMessage = "Limiti kecdiz")]
        public string Description { get; set; }
        [Required,StringLength(255)]
        public string Image { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Bos Saxlamayin")]
        public IFormFile Photo { get; set; }
    }
}
