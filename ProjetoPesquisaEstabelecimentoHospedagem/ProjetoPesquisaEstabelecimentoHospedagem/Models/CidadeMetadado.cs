using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPesquisaEstabelecimentoHospedagem.Models
{
    [MetadataType(typeof(CidadeMetadado))]
    public partial class Cidade { }

    public class CidadeMetadado
    {
        [Required(ErrorMessage = "O nome da cidade é obrigatória", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z\s]{5,40}$", ErrorMessage = "Nome da cidade inválida")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A UF é obrigatória", AllowEmptyStrings = false)]
        [RegularExpression(@"^[A-Z]{2}$", ErrorMessage = "Valor de UF inválida")]

        public string UF { get; set; }
    }
}