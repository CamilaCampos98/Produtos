using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Produtos.Models
{
    public class ProdutoMetadata
    {
        [Display(Name = "Categoria de Produto")]
        public int ID;

    }
}