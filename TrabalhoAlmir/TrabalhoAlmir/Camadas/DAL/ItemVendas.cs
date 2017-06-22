using System;
using System.Collections.Generic;
using System.Data; 
using System.Data.SqlClient; 
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace TrabalhoAlmir.Camadas.DAL
{
    public class ItemVendas
    {
        private string strCon = Conexao.getConexao();

        public List<Model.ItemVendas> Select()
        {
            List<Model.ItemVendas> lstItemVendas = new List<Model.ItemVendas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from ItemVendas;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto ItemLocacao     
                    Model.ItemVendas ItemVendas = new Model.ItemVendas();
                    //carregar os dado no objeto ItemLocacao -- popular objeto
                    ItemVendas.id = Convert.ToInt32(reader["id"]);
                    ItemVendas.vendas = Convert.ToInt32(reader["vendas"]);
                    ItemVendas.produto = Convert.ToInt32(reader["produto"]);
                    ItemVendas.valor = Convert.ToSingle(reader["valor"].ToString());
                    ItemVendas.pago = Convert.ToSingle(reader["pago"].ToString());
                    ItemVendas.troco = Convert.ToSingle(reader["troco"].ToString());

                    lstItemVendas.Add(ItemVendas);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Item Vendas....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstItemVendas;
        }


        public List<Model.ItemVendas> SelectById(int id)
        {
            List<Model.ItemVendas> lstItemVendas = new List<Model.ItemVendas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from ItemVendas where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto Item Vendas     
                    Model.ItemVendas ItemVendas = new Model.ItemVendas();
                    //carregar os dado no objeto ItemLocacao -- popular objeto
                    ItemVendas.id = Convert.ToInt32(reader["id"]);
                    ItemVendas.vendas = Convert.ToInt32(reader["vendas"]);
                    ItemVendas.produto = Convert.ToInt32(reader["produto"]);
                    ItemVendas.valor = Convert.ToSingle(reader["valor"].ToString());
                    ItemVendas.pago = Convert.ToSingle(reader["pago"].ToString());
                    ItemVendas.troco = Convert.ToSingle(reader["troco"].ToString());

                    lstItemVendas.Add(ItemVendas);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Item Vendas por id....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstItemVendas;
        }


        public List<Model.ItemVendas> SelectByVendas(int vendas)
        {
            List<Model.ItemVendas> lstItemVendas = new List<Model.ItemVendas>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from ItemVendas where vendas=@vendas;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@vendas", vendas);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    //instanciando objeto ItemVendas     
                    Model.ItemVendas ItemVendas = new Model.ItemVendas();
                    //carregar os dado no objeto ItemVendas -- popular objeto
                    ItemVendas.id = Convert.ToInt32(reader["id"]);
                    ItemVendas.vendas = Convert.ToInt32(reader["vendas"]);
                    ItemVendas.produto = Convert.ToInt32(reader["produto"]);
                    ItemVendas.valor = Convert.ToSingle(reader["valor"].ToString());
                    ItemVendas.pago = Convert.ToSingle(reader["pago"].ToString());
                    ItemVendas.troco = Convert.ToSingle(reader["troco"].ToString());

                    lstItemVendas.Add(ItemVendas);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Item Vendas por Vendas....;");
            }
            finally
            {
                conexao.Close();
            }
            return lstItemVendas;
        }


        public void Insert(Model.ItemVendas ItemVendas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into ItemVendas values ";
            sql = sql + " (@vendas ,@produto, @valor, @pago, @troco);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@vendas", ItemVendas.vendas);
            cmd.Parameters.AddWithValue("@produto", ItemVendas.produto);
            cmd.Parameters.AddWithValue("@valor", ItemVendas.valor);
            cmd.Parameters.AddWithValue("@pago", ItemVendas.pago);
            cmd.Parameters.AddWithValue("@troco", ItemVendas.troco);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de Item Vendas...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Model.ItemVendas ItemVendas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update ItemVendas set vendas=@vendas, produto=@produto, ";
            sql += "valor=@valor, pago=@pago, troco=@troco ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@vendas", ItemVendas.vendas);
            cmd.Parameters.AddWithValue("@produto", ItemVendas.produto);
            cmd.Parameters.AddWithValue("@valor", ItemVendas.valor);
            cmd.Parameters.AddWithValue("@pago", ItemVendas.pago);
            cmd.Parameters.AddWithValue("@troco", ItemVendas.troco);
            cmd.Parameters.AddWithValue("@id", ItemVendas.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Item Vendas...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.ItemVendas ItemVendas)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from ItemVendas where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", ItemVendas.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro remocao Item Vendas");
            }
            finally
            {
                conexao.Close();
            }
        }




    }
}

