//System.Data.Sql;
//System.Data.SqlClient;

namespace DAL
{
    public static class Conexao
    {
        public static string StringDeConexao
        {
            get
            {
                //return "User ID=SA;Initial Catalog=Loja;Data Source=.\\SQLEXPRESS2019;Password=Senailab05";
                //Data Source = EVANDERSON\SQLEXPRESS; Initial Catalog = ORDEMSERVICO; Integrated Security = True
                return @"Initial Catalog=ORDEMSERVICO; Data Source = EVANDERSON\SQLEXPRESS; Integrated Security=True";
            }
        }
    }
}
