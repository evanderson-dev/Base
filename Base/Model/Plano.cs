namespace Model
{
    public class Plano
    {
        private int id;
        private string descricao;
        private string valor;

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
    }
}
