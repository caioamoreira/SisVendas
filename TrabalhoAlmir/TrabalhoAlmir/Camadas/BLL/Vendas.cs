
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlmir.Camadas.BLL
{
    public class Vendas
    {
        public List<Model.Vendas> Select()
        {
            DAL.Vendas dalVen = new DAL.Vendas();
            return dalVen.Select();
        }

        public List<Model.Vendas> SelectById(int id)
        {
            DAL.Vendas dalVen = new DAL.Vendas();
            return dalVen.SelectById(id);

        }

        public List<Model.Vendas> SelectByCliente(int cliente)
        {
            DAL.Vendas dalVen = new DAL.Vendas();
            return dalVen.SelectByCliente(cliente);
        }


        public void Insert(Model.Vendas Vendas)
        {
            DAL.Vendas dalVen = new DAL.Vendas();
            //regras de negócio caso existam
            dalVen.Insert(Vendas);
        }

        public void Update(Model.Vendas Vendas)
        {
            DAL.Vendas dalVen = new DAL.Vendas();
            dalVen.Update(Vendas);
        }

        public void Delete(Model.Vendas Vendas)
        {
            DAL.Vendas dalVen = new DAL.Vendas();
            dalVen.Delete(Vendas);
        }

    }
}
