using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DependenceAjax.Models
{
    public class DBAjaxDependencyContext:DbContext
    {
        public DBAjaxDependencyContext() : base("connexionDepend") { }
        public DbSet<IA> iAs { get; set; }
        public DbSet<IEF> iEFs { get; set; }
        public DbSet<Etablissement> etablissements { get; set; }
    }
}