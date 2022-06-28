using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model{
    public class Usuario{

        private string nomeUsuario;
        private string nomeCompleto;
        private int id;
        private bool ativo;
        private string senha;
        private int id_Plano;
        private string cpf;
        private string rg;
        private string orgaoExpeditor;
        private string dataNascimento;
        private string rua;
        private string numCasa;
        private string estadoCivil;
        private string nacionalidade;
        private string email;
        private string telefone;
        private string celularUm;
        private string celularDois;
        private string cidade;
        private string uf;
        private int id_Permissao;
        private string salario;
        private string cargo;
        private string dataAdmissao;
        private string dataDemissao;
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
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public string OrgaoExpeditor
        {
            get { return orgaoExpeditor; }
            set { orgaoExpeditor = value; }
        }
        public string DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string NumCasa
        {
            get { return numCasa; }
            set { numCasa = value; }
        }
        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }
        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string CelularUm
        {
            get { return celularUm; }
            set { celularUm = value; }
        }
        public string CelularDois
        {
            get { return celularDois; }
            set { celularDois = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        /////////////////////////////////////
        public int Id_Permissao
        {
            get { return id_Permissao; }
            set { id_Permissao = value; }
        }
        public string Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public string DataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
        }
        public string DataDemissao
        {
            get { return dataDemissao; }
            set { dataDemissao = value; }
        }
    }
}
