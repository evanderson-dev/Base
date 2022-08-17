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
        public DataTable BuscarOrdemServico(string _filtro)
        {
            OrdemServicoDAL ordemServicoDAL = new OrdemServicoDAL();
            return ordemServicoDAL.BuscarOrdemServico(_filtro);
        }
        public DataTable BuscarOSFechada()
        {
            OrdemServicoDAL ordemServicoDAL = new OrdemServicoDAL();
            return ordemServicoDAL.BuscarOSFechada();
        }
        public DataTable BuscarOSAberta()
        {
            OrdemServicoDAL ordemServicoDAL = new OrdemServicoDAL();
            return ordemServicoDAL.BuscarOSAberta();
        }
        public DataTable BuscarOSEncaminhada()
        {
            OrdemServicoDAL ordemServicoDAL = new OrdemServicoDAL();
            return ordemServicoDAL.BuscarOSEncaminhada();
        }
    }
}
