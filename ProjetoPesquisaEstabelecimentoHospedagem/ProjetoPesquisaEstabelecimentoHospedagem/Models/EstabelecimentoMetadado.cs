using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPesquisaEstabelecimentoHospedagem.Models
{
    [MetadataType(typeof(EstabelecimentoMetadado))]
    public partial class Estabelecimento { }

    public class EstabelecimentoMetadado
    {
        [Required(ErrorMessage = "A categoria é obrigatória", AllowEmptyStrings = false)]
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "A cidade é obrigatória", AllowEmptyStrings = false)]
        public int IdCidade { get; set; }

        [Required(ErrorMessage = "O nome comercial é obrigatório", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-ZÁÂáâãÉÊéêÍíÓÔóôõÚúç\s]{5,40}$", ErrorMessage = "Nome comercial inválido")] 
        public string NomeComercial { get; set; }

        [Required(ErrorMessage = "A razão social é obrigatória", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-ZÁÂáâãÉÊéêÍíÓÔóôõÚúç\s]{5,40}$", ErrorMessage = "Razão social inválido")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-ZÁÂáâãÉÊéêÍíÓÔóôõÚúç\s]{5,100}$", ErrorMessage = "Endereço inválida")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório", AllowEmptyStrings = false)]
        [RegularExpression(@"^\(?\d{2}\)?[\s-]?[\s9]?\d{4}-?\d{4}$", ErrorMessage = "Telefone inválido")]
        public string Telefone { get; set; }

        // Não possui RegularExpression, pois já ouvi falar de domínios web que são emoji
        [Required(ErrorMessage = "O site é obrigatório", AllowEmptyStrings = false)]
        public string Site { get; set; }
    }
}