using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ParametroSQL
    {
        private string parametro;
        private string valor;

        public string Parametro
        {
            get { return parametro; }
            set { parametro = value; }
        }

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }


    }
}
