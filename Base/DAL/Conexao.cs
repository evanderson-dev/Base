namespace DAL
{
    public static class Conexao
    {
        public static string StringDeConexao
        {
            get
            {
                // ".\" SIGINIFICA QUE É O ENDEREÇO DA MAQUINA LOCAL.
                // "Integrated Security=True" SIGNIFICA QUE ESTA USANDO A AUTENTICAÇÃO DO WINDOWS.
                //return "User ID=SA;Initial Catalog=ORDEMSERVICO;Data Source=.\\SQLEXPRESS2019;Password=Senailab05";
                return @"Initial Catalog=ORDEMSERVICO; Data Source = EVANDERSON\SQLEXPRESS; Integrated Security=True";
            }
        }
    }
}
