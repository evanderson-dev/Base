﻿using DAL;
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
                throw new Exception("INFORME A DATA DE NASCIMENTO!");

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

        //CRIADO PARA TESTE
        public DataTable BuscarPlano(string _id)
        {
            PlanoDAL planoDAL = new PlanoDAL();
            return planoDAL.BuscarPlano(_id);
        }
        public DataTable BuscarFuncionario(string _filtro)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarFuncionario(_filtro);
        }
        public DataTable BuscarFuncionarioInativo()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarFuncionarioInativo();
        }
        public DataTable BuscarClienteInativo()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarClienteInativo();
        }
        public DataTable BuscarClienteAtivo()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarClienteAtivo();
        }
        public DataTable BuscarClienteFuncionarioInativo()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarClienteFuncionarioInativo();
        }
        public DataTable BuscarClienteFuncionarioAtivo()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarClienteFuncionarioAtivo();
        }
    }
}
