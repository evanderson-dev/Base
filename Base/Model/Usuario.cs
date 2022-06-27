using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model{
    public class Usuario{

        private string nomeUsuario;
        private string nomeCompleto;
        private int id  ;
        private bool ativo;
        private string senha;
        private int id_Plano;
        private string cpf;

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public string NomeCompleto
        {
            get { return nomeCompleto; }
            set { nomeCompleto = value; }
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

        public int Id_Plano
        {
            get { return id_Plano; }
            set { id_Plano = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

    }
}
