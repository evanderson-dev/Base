namespace Model
{
    public class UsuarioLogado
    {
        private int id;
        private string nomeUsuarioLogado;
        private string senhaLogada;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NomeUsuarioLogado
        {
            get { return nomeUsuarioLogado; }
            set { nomeUsuarioLogado = value; }
        }

        public string SenhaLogada
        {
            get { return senhaLogada; }
            set { senhaLogada = value; }
        }
    }
}
