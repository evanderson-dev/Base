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
        private float valor;

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

        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
