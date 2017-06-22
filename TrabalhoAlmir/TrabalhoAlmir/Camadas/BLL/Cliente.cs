using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAlmir.Camadas.Model;

namespace TrabalhoAlmir.Camadas.BLL
{
    public class Cliente
    {
       public  List<Model.Cliente>Select()
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //regras de negócios.
            return dalCli.Select();
        }

        public List<Model.Cliente> SelectById(int id)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //regras de negócios.
            return dalCli.SelectById(id);

        }

        public List<Model.Cliente> SelectByNome(string nome)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //regras de negócios.
            return dalCli.SelectbyNome(nome);
        }



        public void Insert(Model.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //regras de negocio
            dalCli.Insert(cliente);
        }

        public void Uptade (Model.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //regras
            dalCli.Uptade(cliente);
        }

        public void Delete (Model.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            //regras
            dalCli.Delete(cliente);
        }

       
        }
    }

