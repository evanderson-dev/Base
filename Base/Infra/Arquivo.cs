using System.IO;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System;

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
        public static ArrayList BuscarConexoesBD()
        {
            ArrayList retornoArray = new ArrayList();
            try
            {
                // PROCURA TODOS OS ARQUIVOS QUE COMEÇAM COM "BD" NO DIRETORIO ESPECIFICADO, E SALVA TODO O ENDEREÇO DO ARQUIVO
                string[] caminho = Directory.GetFiles(Constante.DiretorioDoEnderecoBanco, "BD*");
                for (int i = 0; i < caminho.Length; i++)
                {
                    string conteudo = File.ReadAllText(caminho[i]);// ADICIONA TODO O CONTEUDO DO ARQUIVO A VARIAVEL
                    retornoArray.Add(FuncoesGlobais.Base64Decode(conteudo));// ADICIONADO O ENDEREÇO DO SERVIDOR CRIPTOGRAFADO
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"O PROCESSO FALHOU: {ex.Message}");
            }
            return retornoArray;
        }
    }
}
