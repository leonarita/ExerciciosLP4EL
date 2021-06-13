using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class Pesquisa
    {
		public static string Text { set; get; }

		public virtual bool BuscarString(string CadeiaCaracteres)
		{
			if (Text is null)
				return false;

			return Text.Contains(CadeiaCaracteres);
		}
	}
}
