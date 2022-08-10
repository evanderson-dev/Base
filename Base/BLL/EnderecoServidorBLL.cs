using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class EnderecoServidorBLL
    {
        public EnderecoServidor Inserir(EnderecoServidor _enderecoServidor)
        {
            EnderecoServidorDAL EnderecoServidorDAL = new EnderecoServidorDAL();
            return EnderecoServidorDAL.Inserir(_enderecoServidor);
        }
        public void Excluir(int _id)
        {
            EnderecoServidorDAL enderecoServidorDAL = new EnderecoServidorDAL();
            enderecoServidorDAL.Excluir(_id);
        }
        public EnderecoServidor Alterar(EnderecoServidor _enderecoServidor)
        {
            EnderecoServidorDAL enderecoServidorDAL = new EnderecoServidorDAL();
            return enderecoServidorDAL.Alterar(_enderecoServidor);
        }
        public DataTable Buscar(string _filtro)
        {
            EnderecoServidorDAL enderecoServidorDAL = new EnderecoServidorDAL();
            return enderecoServidorDAL.Buscar(_filtro);
        }
    }
}
