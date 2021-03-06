//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoPesquisaEstabelecimentoHospedagem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estabelecimento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estabelecimento()
        {
            this.Quarto = new HashSet<Quarto>();
        }
    
        public int IdEstabelecimento { get; set; }
        public int IdCategoria { get; set; }
        public int IdCidade { get; set; }
        public string NomeComercial { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Site { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Cidade Cidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quarto> Quarto { get; set; }
    }
}
