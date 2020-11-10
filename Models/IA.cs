using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DependenceAjax.Models
{
    public class IA
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Le nom de l'IA"), Required(ErrorMessage = "*")]
        public string NomIA { get; set; }
    }
}