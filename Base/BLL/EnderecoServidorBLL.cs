using DAL;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class EnderecoServidorBLL
    {
        public List<EnderecoServidor> Buscar()
        {
            List<EnderecoServidor> retorno = new List<EnderecoServidor>();
            EnderecoServidor enderecoServidor = new EnderecoServidor();
            ArrayList conexoes = Infra.Arquivo.BuscarConexoes();

            foreach (var item in conexoes)
            {
                enderecoServidor = new EnderecoServidor();
                enderecoServidor.Descricao = item.ToString().Split('|')[0];
                enderecoServidor.StringDeConexao = item.ToString().Split('|')[1];
                retorno.Add(enderecoServidor);
            }
            return retorno;
        }
    }
}
