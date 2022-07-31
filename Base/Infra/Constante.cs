using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public static class Constante
    {
        public static string DiretorioDeImagem = Environment.CurrentDirectory + "\\Imgs\\";
        public static string DiretorioDePDF = Environment.CurrentDirectory + @"\PDF\";
    }
    public static class UsuarioLogado
    {
        public static string Id = null;
        public static string NomeUsuario = null;
        public static string NomeCompleto = null;
    }
}
