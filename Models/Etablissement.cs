using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DependenceAjax.Models
{
    public class Etablissement
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Le nom de l'étatblissement"), Required(ErrorMessage = "*")]
        public string NomEtablissement { get; set; }
        [Display(Name = "L'IEF"), Required(ErrorMessage = "*")]
        public int IEFId { get; set; }
        public virtual IEF IEF { get; set; }
    }
}