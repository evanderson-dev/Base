using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class TipoChamadoBLL
    {
        public TipoChamado InserirTipoChamado(TipoChamado _tipoChamado)
        {
            TipoChamadoDAL tipoChamadoDAL = new TipoChamadoDAL();
            return tipoChamadoDAL.InserirTipoChamado(_tipoChamado);
        }
        public void ExcluirTipoChamado(int _id)
        {
            TipoChamadoDAL tipoChamadoDAL = new TipoChamadoDAL();
            tipoChamadoDAL.ExcluirTipoChamado(_id);
        }
        public TipoChamado AlterarTipoChamado(TipoChamado _tipoChamado)
        {
            TipoChamadoDAL tipoChamadoDAL = new TipoChamadoDAL();
            return tipoChamadoDAL.AlterarTipoChamado(_tipoChamado);
        }
        public DataTable BuscarTipoChamado(string _filtro)
        {
            TipoChamadoDAL tipoChamadoDAL = new TipoChamadoDAL();
            return tipoChamadoDAL.BuscarTipoChamado(_filtro);
        }
    }
}
