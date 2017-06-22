﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlmir.Camadas.BLL
{
    public class Produto
    {
        public List<Model.Produto> Select()
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.Select();
        }

        public List<Model.Produto> SelectById(int id)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectById(id);
        }


        public List<Model.Produto> SelectByDescricao(string desc)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectByDescricao(desc);
        }

        public void Insert(Model.Produto Produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            //regras de negócio caso existam
            dalProd.Insert(Produto);
        }

        public void Update(Model.Produto Produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            dalProd.Update(Produto);
        }

        public void Delete(Model.Produto Produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            dalProd.Delete(Produto);
        }

    }
}
