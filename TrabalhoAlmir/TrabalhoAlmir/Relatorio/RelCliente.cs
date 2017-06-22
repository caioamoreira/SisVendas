using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrabalhoAlmir.Relatorio
{
    public class relCliente
    {
        public static void impRelCliente()
        {
            //carregando dados para impressão - gerar lista de cliente
            List<Camadas.Model.Cliente> lstCli = new List<Camadas.Model.Cliente>();
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            lstCli = bllCli.Select();

            //configurando e iniciando relatório
            string folder = funRel.diretorioPasta();
            string arquivo = folder + @"\relCliente.html";
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine(@"<meta http-equiv=\Content-type\Content=\'html; charset=utf-8\'");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatório de Clientes</h1>");
                //definicao tabela
                sw.WriteLine("<table>");
                //cabeçalho tabela
                sw.WriteLine("<tr>");
                sw.WriteLine("<th width ='30px'  align='right'>ID</th>");
                sw.WriteLine("<th width ='150px' align='left'>NOME</th>");
                sw.WriteLine("<th width ='90px'  align='right'>ENDEREÇO</th>");
                sw.WriteLine("<th width ='90px'  align='right'>NUMERO</th>");
                sw.WriteLine("<th width ='90px'  align='right'>CIDADE</th>");
                sw.WriteLine("<th width ='90px'  align='right'>ESTADO</th>");
                sw.WriteLine("<th width ='90px'  align='center'>FONE</th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                float soma = 0;
                //detalhes, itens do relatorio
                foreach (Camadas.Model.Cliente cliente in lstCli)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width ='30px'  align='right'>" + cliente.id + "</td>");
                    sw.WriteLine("<td width ='150px' align='left'>" + cliente.nome + "</td>");
                    sw.WriteLine("<td width ='90px'  align='right'>" + cliente.endereco + "</td>");
                    sw.WriteLine("<td width ='90px'  align='right'>" + cliente.numero + "</td>");
                    sw.WriteLine("<td width ='90px'  align='right'>" + cliente.cidade + "</td>");
                    sw.WriteLine("<td width ='90px'  align='center'>" + cliente.estado + "</td>");
                    sw.WriteLine("<td width ='90px'  align='center'>" + cliente.fone + "</td>");
                    sw.WriteLine("</tr>");
                    cont++;
                   

                }
                //fim da tabela 
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' width='300px' border='2px'>");
                sw.WriteLine("<h5>Total de Cliente Impressos: " + cont + "</h5>");
                

                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);

        }
    }

}
