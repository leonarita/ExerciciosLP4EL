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
    
    public partial class TipoQuarto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoQuarto()
        {
            this.Quarto = new HashSet<Quarto>();
        }
    
        public int IdTipoQuarto { get; set; }
        public string Descricao { get; set; }
        public decimal ValorDiaria { get; set; }
        public bool CafeManha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quarto> Quarto { get; set; }
    }
}
