using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            if (_usuario.DataNascimento.ToString().Trim().Length < 6)
                throw new Exception("Informe a data de nascimento.");
            if (_usuario.DataAdmissao.ToString().Trim().Length < 6)
                throw new Exception("Informe a data de admissão.");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }
        public Usuario Alterar(Usuario _usuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Alterar(_usuario);
        }
        public DataTable Buscar(string _filtro)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Buscar(_filtro);
        }
    }
}
