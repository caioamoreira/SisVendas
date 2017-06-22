using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlmir.Camadas.BLL
{
    public class ItemVendas
    {
        public List<Model.ItemVendas> Select()
        {
            DAL.ItemVendas dalItmVen = new DAL.ItemVendas();
            //regras de negócio caso existam
            return dalItmVen.Select();
        }

        public List<Model.ItemVendas> SelectById(int id)
        {
            DAL.ItemVendas dalItmVen = new DAL.ItemVendas();
            //regras de negócio caso existam
            return dalItmVen.SelectById(id);

        }

        public List<Model.ItemVendas> SelectByVendas(int vendas)
        {
            DAL.ItemVendas dalItmVen = new DAL.ItemVendas();
            //regras de negócio caso existam
            return dalItmVen.SelectByVendas(vendas);
        }


        public void Insert(Model.ItemVendas ItemVendas)
        {
            DAL.ItemVendas dalItmVen = new DAL.ItemVendas();
            //regras de negócio caso existam
            dalItmVen.Insert(ItemVendas);
        }

        public void Update(Model.ItemVendas ItemVendas)
        {
            DAL.ItemVendas dalItmVen = new DAL.ItemVendas();
            dalItmVen.Update(ItemVendas);
        }

        public void Delete(Model.ItemVendas ItemVendas)
        {
            DAL.ItemVendas dalItmVen = new DAL.ItemVendas();
            dalItmVen.Delete(ItemVendas);
        }

        public void Baixa(Model.ItemVendas ItemVendas)
        {
            DAL.ItemVendas dalItmVen = new DAL.ItemVendas();
            //atualização da tabela produto para gravar V  de Livre
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            //recupera produto
            Model.Produto produto = new Model.Produto();
            List<Model.Produto> lstProd = new List<Model.Produto>();
            lstProd = bllProd.SelectById(ItemVendas.produto);
            produto = lstProd[0];
            //muda status produto
            produto.status = 'E';
            produto.quantidade = produto.quantidade - 1;

            //atualiza produto
            bllProd.Update(produto);

            //gravar item locacao
            dalItmVen.Update(ItemVendas);

        }

    }
}



