namespace Model
{
    public class EnderecoServidor
    {
        private int id;
        private string stringDeConexao;
        private string descricao;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string StringDeConexao
        {
            get { return stringDeConexao; }
            set { stringDeConexao = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
