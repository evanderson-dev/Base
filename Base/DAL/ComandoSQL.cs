using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class ComandoSQL
    {
        private SqlCommand comando;
        private List<ParametroSQL> parametros;

        public List<ParametroSQL> Parametros
        {
            get { return parametros; }
            set { parametros = value; }
        }

        public SqlCommand Comando   
        {
            get { return comando; }
            set { comando = value; }
        }
    }
}
