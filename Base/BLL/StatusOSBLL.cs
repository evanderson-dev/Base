using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class StatusOSBLL
    {
        public StatusOS Inserir(StatusOS _statusOS)
        {
            StatusOSDAL statusOSDAL = new StatusOSDAL();
            return statusOSDAL.Inserir(_statusOS);
        }
        public void Excluir(int _id)
        {
            StatusOSDAL statusOSDAL = new StatusOSDAL();
            statusOSDAL.Excluir(_id);
        }
        public StatusOS Alterar(StatusOS _statusOS)
        {
            StatusOSDAL statusOSDAL = new StatusOSDAL();
            return statusOSDAL.Alterar(_statusOS);
        }
        public DataTable BuscarStatusOS(string _filtro)
        {
            StatusOSDAL statusOSDAL = new StatusOSDAL();
            return statusOSDAL.Buscar(_filtro);
        }
    }
}
