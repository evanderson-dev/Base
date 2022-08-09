namespace Model
{
    public class Plano
    {
        private int id;
        private string descricao;
        private string valor;
        private string stringDeConexao;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string StringDeConexao
        {
            get { return stringDeConexao; }
            set { stringDeConexao = value; }
        }
    }
}
