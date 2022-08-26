using System.IO;
using System.Collections;

namespace Infra
{
    public static class Arquivo
    {
        public static ArrayList BuscarConexoesBD()
        {
            ArrayList retornoArray = new ArrayList();
            // PROCURA TODOS OS ARQUIVOS QUE COMEÇAM COM "BD" NO DIRETORIO ESPECIFICADO, E SALVA TODO O ENDEREÇO DO ARQUIVO
            string[] caminho = Directory.GetFiles(Constante.DiretorioDoEnderecoBanco, "BD*");
            for (int i = 0; i < caminho.Length; i++)
            {
                string conteudo = File.ReadAllText(caminho[i]);// ADICIONA TODO O CONTEUDO DO ARQUIVO A VARIAVEL
                retornoArray.Add(FuncoesGlobais.Base64Decode(conteudo));// ADICIONADO O ENDEREÇO DO SERVIDOR CRIPTOGRAFADO
            }
            return retornoArray;
        }
    }
}
