using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class TipoChamadoBLL
    {
        public TipoChamado Inserir(TipoChamado _tipoChamado)
        {
            TipoChamadoDAL tipoChamadoDAL = new TipoChamadoDAL();
            return tipoChamadoDAL.Inserir(_tipoChamado);
        }
        public void Excluir(int _id)
        {
            TipoChamadoDAL tipoChamadoDAL = new TipoChamadoDAL();
            tipoChamadoDAL.Excluir(_id);
        }
        public TipoChamado Alterar(TipoChamado _tipoChamado)
        {
            TipoChamadoDAL tipoChamadoDAL = new TipoChamadoDAL();
            return tipoChamadoDAL.Alterar(_tipoChamado);
        }
        public DataTable BuscarTipoChamado(string _filtro)
        {
            TipoChamadoDAL tipoChamadoDAL = new TipoChamadoDAL();
            return tipoChamadoDAL.Buscar(_filtro);
        }
    }
}
