
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TrabalhoAlmir.Camadas.DAL
{
    public class Vendas
    {
        private string strCon = Conexao.getConexao();


        public List<Model.Vendas> Select()
        {
            List<Model.Vendas> lstVendas = new List<Model.Vendas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select Vendas.id, Vendas.data, Vendas.cliente, Cliente.nome from Vendas inner join Cliente on Cliente.id=Vendas.cliente;"; // pode dar erro
            //string sql = "select  * from Vendas;"; // pode dar erro
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Vendas     
                    Model.Vendas Vendas = new Model.Vendas();
                    //carregar os dado no objeto Vendas -- popular objeto
                    Vendas.id = Convert.ToInt32(reader["id"]);
                    Vendas.data = Convert.ToDateTime(reader["data"].ToString());
                    Vendas.cliente = Convert.ToInt32(reader["cliente"]);
                    Vendas.nome = reader["nome"].ToString();
                    lstVendas.Add(Vendas);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Vendas....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstVendas;
        }

        public List<Model.Vendas> SelectById(int id)
        {
            List<Model.Vendas> lstVendas = new List<Model.Vendas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Vendas where id=@id;";// pode dar erro
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Vendas    
                    Model.Vendas Vendas = new Model.Vendas();
                    //carregar os dado no objeto Vendas -- popular objeto
                    Vendas.id = Convert.ToInt32(reader["id"]);
                    Vendas.cliente = Convert.ToInt32(reader["cliente"]);
                    Vendas.data = Convert.ToDateTime(reader["data"].ToString());
                    Vendas.nome = reader["nome"].ToString();
                    lstVendas.Add(Vendas);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Vendas....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstVendas;
        }


        public List<Model.Vendas> SelectByCliente(int cliente)
        {
            List<Model.Vendas> lstVendas = new List<Model.Vendas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Vendas where cliente=@cliente;"; // pode dar erro
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cliente", cliente);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Vendas    
                    Model.Vendas Vendas = new Model.Vendas();
                    //carregar os dado no objeto Vendas -- popular objeto
                    Vendas.id = Convert.ToInt32(reader["id"]);
                    Vendas.cliente = Convert.ToInt32(reader["cliente"]);
                    Vendas.data = Convert.ToDateTime(reader["data"].ToString());
                    Vendas.nome = reader["nome"].ToString();
                    lstVendas.Add(Vendas);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Vendas....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstVendas;
        }


        public void Insert(Model.Vendas Vendas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Vendas values ";
            sql = sql + " (@data, @cliente , @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@data", Vendas.data);
            cmd.Parameters.AddWithValue("@cliente", Vendas.cliente);
            cmd.Parameters.AddWithValue("@nome", Vendas.nome);


            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Vendas...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.Vendas Vendas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Vendas set data=@data, cliente=@cliente, nome=@nome ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@data", Vendas.data);
            cmd.Parameters.AddWithValue("@cliente", Vendas.cliente);
            cmd.Parameters.AddWithValue("@nome", Vendas.nome);
            cmd.Parameters.AddWithValue("@id", Vendas.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Vendas...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Vendas Vendas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Vendas where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", Vendas.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remocao Vendas");
            }
            finally
            {
                conexao.Close();
            }
        }
    }


}

