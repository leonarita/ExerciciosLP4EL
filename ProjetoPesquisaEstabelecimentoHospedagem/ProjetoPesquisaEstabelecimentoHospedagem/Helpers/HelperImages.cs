using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPesquisaEstabelecimentoHospedagem.Helpers
{
    public static class HelperImages
    {
        public static MvcHtmlString ExibeImagens(this HtmlHelper hp)
        {
            string str = "<div style='width:100%; text-align:center; padding:10px'>" +
                         "<div style='width:35%; height:50%; margin:5px; display:inline-block'> " +
                         "<img style='width: 400px; height: 400px;' src='Images/cadastro.png' /> </div>" +
                         "<div style='width:35%; height:50%; margin:5px; display:inline-block'> " +
                         "<img style='width: 400px; height: 400px;' src='Images/campainha.jpg' /> </div>" +
                         "</div>";

            return new MvcHtmlString(str);
        }
    }
}