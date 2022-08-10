using System;
using System.IO;
using System.Text;

namespace Infra
{
    public static class Constante
    {
        public static string DiretorioDeImagem = Environment.CurrentDirectory + "\\Imgs\\";
        public static string DiretorioDePDF = Environment.CurrentDirectory + @"\PDF\";
        public static string DiretorioDoEnderecoBanco = Environment.CurrentDirectory + @"\Servidores\";
        public static string NomeArquivoBanco = "Bancos.txt";
    }
    public static class UsuarioLogado
    {
        public static string Id = null;
        public static string NomeUsuario = null;
        public static string NomeCompleto = null;
    }

    public static class ArquivoBanco
    {
        public static void GravarEnderecoBancoNoFinalDoArquivo(string _texto, string _caminho)
        {
            FileStream fileStream = new FileStream(_caminho, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
            streamWriter.WriteLine(_texto);

            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }

        public static void GravarBanco(string _texto)
        {
            CriarPasta(Constante.DiretorioDoEnderecoBanco);
            GravarEnderecoBancoNoFinalDoArquivo(_texto, Constante.DiretorioDoEnderecoBanco + "\\" + Constante.NomeArquivoBanco);
        }

        public static void CriarPasta(string _caminho)
        {
            Directory.CreateDirectory(_caminho);
        }
    }
}
