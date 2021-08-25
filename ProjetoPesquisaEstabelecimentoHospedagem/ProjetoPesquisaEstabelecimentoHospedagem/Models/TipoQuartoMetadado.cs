using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPesquisaEstabelecimentoHospedagem.Models
{
    [MetadataType(typeof(TipoQuartoMetadado))]
    public partial class TipoQuarto { }

    public class TipoQuartoMetadado
    {

        [Required(ErrorMessage = "A descrição é obrigatória", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-ZÁÂáâãÉÊéêÍíÓÔóôõÚúç\s]{5,40}$", ErrorMessage = "Descrição inválida")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O valor diário é obrigatório", AllowEmptyStrings = false)]
        [Range(20, 200, ErrorMessage = "O valor diário deve ser entre R$20,00 e R$200,00")]
        [DataType(DataType.Currency)]
        public decimal ValorDiaria { get; set; }
    }
}