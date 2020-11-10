using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DependenceAjax.Models
{
    public class IEF
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Le nom de l'IEF"), Required(ErrorMessage = "*")]
        public string NomIEF { get; set; }
        [Display(Name = "L'IA"), Required(ErrorMessage = "*")]
        public int IAId { get; set; }
        public virtual IA IA { get; set; }
    }
}