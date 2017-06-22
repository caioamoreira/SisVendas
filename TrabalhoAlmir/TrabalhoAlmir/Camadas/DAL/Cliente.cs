using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TrabalhoAlmir.Camadas.Model;

namespace TrabalhoAlmir.Camadas.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();
       // private List<Model.Cliente> lstCliente;

        public List<Model.Cliente> Select()
        {
            List<Model.Cliente> lstCliente = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select  * from Cliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();// preenchendo a classe 
                    //carregar os dados no objeto cliente
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.numero = reader["numero"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.fone = reader["fone"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de cliente");
            }
            finally
            {
                conexao.Close();
            }


            return lstCliente;

        }

        
        public List<Model.Cliente> SelectById( int id)
        {
            List<Model.Cliente> lstCliente = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select  * from Cliente where id = @id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();// preenchendo a classe 
                    //carregar os dados no objeto cliente
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.numero = reader["numero"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.fone = reader["fone"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de cliente");
            }
            finally
            {
                conexao.Close();
            }


            return lstCliente;

        }

        public List<Model.Cliente> SelectbyNome(string nome)
        {
            List<Model.Cliente> lstCliente = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select  * from Cliente where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open();
            try
            {

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();// preenchendo a classe 
                    //carregar os dados no objeto cliente
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.numero = reader["numero"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.fone = reader["fone"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro na consulta de cliente");
            }
            finally
            {
                conexao.Close();
            }


            return lstCliente;

        }


        public void Insert(Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Insert into Cliente values ";
            sql = sql +" (@nome, @endereco, @numero, @cidade, @estado, @fone);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@numero", cliente.numero);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@fone", cliente.fone);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro inserção de cliente...");
       
            }
            finally
            {
                conexao.Close(); 
            }
        }
        public void Uptade(Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cliente set  nome =@nome, endereco = @endereco, numero=@numero, ";
            sql += "cidade =@cidade, estado=@estado, fone=@fone ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@numero", cliente.numero);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@fone", cliente.fone);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine(" Erro na atualização de Clientes..");
            }
            finally
            {
                conexao.Close();
            }
        }

            public void Delete(Model.Cliente cliente)
            {
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "Delete from Cliente where id=@id; ";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", cliente.id);
                conexao.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine(" Erro na remocao de Cliente");
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
    }

