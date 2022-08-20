using System.IO;
using System.Collections;
using System.Text;

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
                    retorno.Add(FuncoesGlobais.Base64Decode(conteudo));// ADICIONADO O ENDEREÇO DO SERVIDOR CRIPTOGRAFADO

                contador++;
                caminho = string.Format("{0}{1}{2}.txt", Constante.DiretorioDoEnderecoBanco, arquivo, contador);
            }
            return retorno;
        }
    }
}
