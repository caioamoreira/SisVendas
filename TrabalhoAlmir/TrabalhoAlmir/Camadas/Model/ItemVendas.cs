using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlmir.Camadas.Model
{
    public class ItemVendas
    {
        public int id { get; set; }
        public int vendas { get; set; }
        public int produto { get; set; }
        public float valor { get; set; }
        public float pago { get; set; }
        public float troco { get; set; }
    }
}

