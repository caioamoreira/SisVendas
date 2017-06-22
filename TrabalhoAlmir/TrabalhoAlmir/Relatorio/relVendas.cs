using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrabalhoAlmir.Relatorio
{
    public class relVendas
    {
        public static void impRelVendas()
        {
            //carregando dados para impressão - gerar lista de produtos
            List<Camadas.Model.ItemVendas> lstItmVen = new List<Camadas.Model.ItemVendas>();
            Camadas.BLL.ItemVendas bllItmVen = new Camadas.BLL.ItemVendas();
            lstItmVen = bllItmVen.Select();

            //configurando e iniciando relatório
            string folder = funRel.diretorioPasta();
            string arquivo = folder + @"\relVendas.html";
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine(@"<meta http-equiv=\Content-type\Content=\'html; charset=utf-8\'");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatório de Vendas</h1>");
                //definicao tabela
                sw.WriteLine("<table>");
                //cabeçalho tabela
                sw.WriteLine("<tr>");
                sw.WriteLine("<th width ='30px'  align='right'>ID</th>");
                sw.WriteLine("<th width ='150px' align='left'>PRODUTO</th>");
                sw.WriteLine("<th width ='90px'  align='right'>VALOR</th>");
                sw.WriteLine("<th width ='90px'  align='center'>PAGO</th>");
              //  sw.WriteLine("<th width ='90px'  align='center'>TROCO</th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                float soma = 0;
                //detalhes, itens do relatorio
                foreach (Camadas.Model.ItemVendas itemvendas in lstItmVen)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width ='30px'  align='right'>" + itemvendas.id + "</td>");
                    sw.WriteLine("<td width ='150px' align='left'>" + itemvendas.produto + "</td>");
                    sw.WriteLine("<td width ='90px'  align='right'>" + itemvendas.valor.ToString("0.00") + "</td>");
                    sw.WriteLine("<td width ='90px'  align='right'>" + itemvendas.pago.ToString("0.00") + "</td>");
                 //   sw.WriteLine("<td width ='90px'  align='right'>" + itemvendas.troco.ToString("0.00") + "</td>");
                    
                    sw.WriteLine("</tr>");
                    cont++;
                    soma = soma + itemvendas.valor;

                }
                //fim da tabela 
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' width='300px' border='2px'>");
                sw.WriteLine("<h5>Total de Vendas Impressos: " + cont + "</h5>");
                sw.WriteLine("<h5>Total da soma do Valor R$ " + soma.ToString("0.00") + "</h5>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);

        }
    }

}
