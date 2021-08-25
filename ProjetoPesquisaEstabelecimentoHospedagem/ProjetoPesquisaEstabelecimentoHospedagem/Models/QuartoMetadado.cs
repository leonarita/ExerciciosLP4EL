using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPesquisaEstabelecimentoHospedagem.Models
{
    [MetadataType(typeof(QuartoMetadado))]
    public partial class Quarto { }

    public class QuartoMetadado
    {
        [Required(ErrorMessage = "O número do quarto é obrigatório", AllowEmptyStrings = false)]
        [Remote("VerificaSeNumeroQuartoNaoExiste", "Quarto", AdditionalFields = "IdEstabelecimento", ErrorMessage = "Quarto já cadastrado")]
        public int NumeroQuarto { get; set; }

        [Required(ErrorMessage = "O estabelecimento é obrigatório", AllowEmptyStrings = false)]
        public int IdEstabelecimento { get; set; }
    }
}