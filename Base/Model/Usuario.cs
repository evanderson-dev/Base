using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model{
    public class Usuario{

        private string nomeUsuario;
        private int id  ;
        private bool ativo;
        private string senha;

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public bool Ativo  
        {
            get { return ativo; }
            set { ativo = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

    }
}
