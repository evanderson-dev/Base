using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Infra
{
    public static class Arquivo
    {
        public static ArrayList BuscarConexoes()
        {
            string arquivo = "BD";
            int contador = 1;
            string caminho = string.Format("{0}{1}{2}.txt", Constante.DiretorioDoEnderecoBanco, arquivo, contador);
            ArrayList retorno = new ArrayList();
            
            while (File.Exists(caminho))
            {
                string conteudo = File.ReadAllText(caminho);
                if (!string.IsNullOrEmpty(conteudo))
                    retorno.Add(conteudo);

                contador++;
                caminho = string.Format("{0}{1}{2}.txt", Constante.DiretorioDoEnderecoBanco, arquivo, contador);
            }
            return retorno;
        }
    }
}
