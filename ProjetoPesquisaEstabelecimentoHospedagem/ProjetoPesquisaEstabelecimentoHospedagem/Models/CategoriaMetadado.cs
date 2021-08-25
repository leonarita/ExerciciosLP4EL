using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPesquisaEstabelecimentoHospedagem.Models
{
    [MetadataType(typeof(CategoriaMetadado))]
    public partial class Categoria { }

    public class CategoriaMetadado
    {
        [Required(ErrorMessage = "A categoria é obrigatória", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-ZÁÂáâãÉÊéêÍíÓÔóôõÚúç\s]{5,40}$", ErrorMessage ="Valor de categoria inválida")]
        public string Descricao { get; set; }

    }
}