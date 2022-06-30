using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
