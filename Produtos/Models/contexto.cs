using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Produtos.Models
{
    public class contexto: DbContext
    {
        public DbSet<produto>Produtos { get; set; }
    }
}