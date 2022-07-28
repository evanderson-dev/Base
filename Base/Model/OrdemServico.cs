namespace Model
{
    public class OrdemServico
    {
        private int id;
        private string protocolo;
        private int id_Cliente;
        private string tipoChamado;
        private string descricao;
        private string dataAbertura;
        private string dataPrazo;
        private string dataDeFechamento;
        private string tecnicoResponsavel;
        private string atendente;
        private string estatusOS;
        private string ligarAntes;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Protocolo
        {
            get { return protocolo; }
            set { protocolo = value; }
        }
        public int Id_Cliente
        {
            get { return id_Cliente; }
            set { id_Cliente = value; }
        }
        public string TipoChamado
        {
            get { return tipoChamado; }
            set { tipoChamado = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public string DataAbertura
        {
            get { return dataAbertura; }
            set { dataAbertura = value; }
        }
        public string DataPrazo
        {
            get { return dataPrazo; }
            set { dataPrazo = value; }
        }
        public string DataDeFechamento
        {
            get { return dataDeFechamento; }
            set { dataDeFechamento = value; }
        }
        public string TecnicoResponsavel
        {
            get { return tecnicoResponsavel; }
            set { tecnicoResponsavel = value; }
        }
        public string Atendente
        {
            get { return atendente; }
            set { atendente = value; }
        }
        public string EstatusOS
        {
            get { return estatusOS; }
            set { estatusOS = value; }
        }
        public string LigarAntes
        {
            get { return ligarAntes; }
            set { ligarAntes = value; }
        }
    }
}