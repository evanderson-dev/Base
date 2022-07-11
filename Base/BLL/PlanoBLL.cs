using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class PlanoBLL
    {
        public Plano Inserir(Plano _plano)
        {
            PlanoDAL planoDAL = new PlanoDAL();
            return planoDAL.Inserir(_plano);
        }
        public void Excluir(int _id)
        {
            PlanoDAL planoDAL = new PlanoDAL();
            planoDAL.Excluir(_id);
        }
        public Plano Alterar(Plano _plano)
        {
            PlanoDAL planoDAL = new PlanoDAL();
            return planoDAL.Alterar(_plano);
        }
        public DataTable BuscarPlano(string _filtro)
        {
            PlanoDAL planoDAL = new PlanoDAL();
            return planoDAL.BuscarPlano(_filtro);
        }
    }
}
