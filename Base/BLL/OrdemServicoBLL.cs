using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class OrdemServicoBLL
    {
        public OrdemServico AbrirOS(OrdemServico _ordemServico)
        {
            OrdemServicoDAL ordemServicoDAL = new OrdemServicoDAL();
            return ordemServicoDAL.AbrirOS(_ordemServico);
        }
        public OrdemServico AlterarOS(OrdemServico _ordemServico)
        {
            OrdemServicoDAL ordemServicoDAL = new OrdemServicoDAL();
            return ordemServicoDAL.AlterarOrdemServico(_ordemServico);
        }
        public DataTable BuscarOS(string _filtro)
        {
            OrdemServicoDAL ordemServicoDAL = new OrdemServicoDAL();
            return ordemServicoDAL.BuscarOrdemServico(_filtro);
        }

        public DataTable BuscarOSPendente()
        {
            OrdemServicoDAL ordemServicoDAL = new OrdemServicoDAL();
            return ordemServicoDAL.BuscarOSPendete();
        }
        //BuscarOrdemServico
        public DataTable BuscarOrdemServico(string _filtro)
        {
            OrdemServicoDAL ordemServicoDAL = new OrdemServicoDAL();
            return ordemServicoDAL.BuscarOrdemServico(_filtro);
        }
    }
}
