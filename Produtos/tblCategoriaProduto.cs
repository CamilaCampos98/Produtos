//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Produtos
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCategoriaProduto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Nullable<bool> Ativo { get; set; }
    
        public virtual tblProduto tblProduto { get; set; }
    }
}
