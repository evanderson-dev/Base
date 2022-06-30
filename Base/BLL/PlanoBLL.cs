using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class PlanoBLL
    {
        public void Inserir(Plano _plano)
        {
            PlanoDAL planoDAL = new PlanoDAL();
            planoDAL.Inserir(_plano);
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
        public DataTable Buscar(string _filtro)
        {
            PlanoDAL planoDAL = new PlanoDAL();
            return planoDAL.Buscar(_filtro);
        }
    }
}
