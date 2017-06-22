using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlmir.Camadas.DAL
{
     public class Conexao
    {
       public static string getConexao()
        {
            return @"Data Source=.\sqlexpress;Initial Catalog=TrabalhoAlmir;Integrated Security=True";
        }
    }
}
