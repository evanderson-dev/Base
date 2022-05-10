using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Banco
    {
        readonly SqlTransaction t = null;
        readonly SqlConnection cn = null;
        public Banco()
        {
            t = cn.BeginTransaction(IsolationLevel.Serializable);
            cn = new SqlConnection("");
        }
        public bool ExecutarComando(List<ComandoSQL> _cmd)
        {
            foreach (var item in _cmd)
            {
                item.Comando.Transaction = t;
                foreach (var p in item.Parametros)
                {
                    item.Comando.Parameters.AddWithValue(p.Parametro, p.Valor);
                }
                item.Comando.ExecuteNonQuery();
            }
            t.Commit();
            return true;
        }
    }
}
