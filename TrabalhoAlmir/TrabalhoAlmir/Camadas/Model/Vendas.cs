using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlmir.Camadas.Model
{
    public class Vendas
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public int cliente { get; set; }
        public string nome { get; set; }
    }
}

