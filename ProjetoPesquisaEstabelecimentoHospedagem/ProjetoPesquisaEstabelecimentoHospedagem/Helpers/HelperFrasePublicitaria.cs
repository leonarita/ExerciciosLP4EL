using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPesquisaEstabelecimentoHospedagem.Helpers
{
    public static class HelperFrasePublicitaria
    {
        public static MvcHtmlString ExibeFrasePublicitaria(this HtmlHelper hp)
        {
            string str = "<h1 style='display:flex; flex-direction:column; justify-content:center; align-items:center;'>" +
                         "Sua hospedagem, nossa companhia" + 
                         "</h1>";

            return new MvcHtmlString(str);
        }
    }
}