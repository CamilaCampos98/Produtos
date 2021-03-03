using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Produtos.Models
{
    public class produto
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public bool Perecivel { get; set; }
        public int CategoriaID { get; set; }


     }
    


}