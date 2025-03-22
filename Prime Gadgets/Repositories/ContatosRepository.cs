using Prime_Gadgets.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Gadgets.Repository
{
    public class ContatosRepository
    {
        public readonly string connectionString = "Data Source=.;Initial Catalog=hhhggh;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public List<Contatos> GetAllContatos()
        {
            var contatos = new List<Contatos>();
            try{
                using (SqlConnection connection = new SqlConnection(connectionString)) { 
                    connection.Open();
                    string sql = "SELECT * FROM contatos ORDER BY id";
                    using (SqlCommand command = new SqlCommand(sql, connection)) {
                        using (SqlDataReader reader = command.ExecuteReader())
                            while (reader.Read()) {

                                Contatos contato = new Contatos();
                                contato.Id = reader.GetInt32(0);
                                contato.Nome = reader.GetString(1);
                                contato.Sobrenome = reader.GetString(2);
                                contato.Telefone = reader.GetInt32(3);
                                contato.Email = reader.GetString(4);
                                contatos.Add(contato);
                            }
                    } 
                }
            }
            catch (Exception ex){
                const string message = ("Cannot connect to the database. ");
                Console.WriteLine(message + ex);
            }

            return contatos;
        }
    
        public Contatos? GetContato(int id) {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM contatos WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection)) 
                    { 
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            if (reader.Read()) {
                                Contatos contato = new Contatos();
                                contato.Id = reader.GetInt32(0);
                                contato.Nome = reader.GetString(1);
                                contato.Sobrenome = reader.GetString(2);
                                contato.Telefone = reader.GetInt32(3);
                                contato.Email = reader.GetString(4);

                                return contato;
                            }
                            else
                                return null;
                        }
                    }
                }
            }
            catch (Exception ex){
                const string message = ("Id not found.");
                Console.WriteLine(message + ex);

            }

            return null;
        }

        public void CreateContatos(Contatos contato) {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO contatos (id, nome, sobrenome, telefone, email)" +
                        "VALUES (@id,@nome,@sobrenome,@telefone,@email)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", "id");
                        command.Parameters.AddWithValue("@nome","nome");
                        command.Parameters.AddWithValue("@sobrenome", "sobrenome");
                        command.Parameters.AddWithValue("@telefone", "telefone");
                        command.Parameters.AddWithValue("@email", "email");

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                const string message = ("Error creating contato. ");
                Console.WriteLine(message + ex);

            }
        }
        
        public void UpdateContatos(Contatos contatos)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE contatos SET nome = @nome, sobrenome = @sobrenome, telefone = @telefone, email = @email WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", "id");
                        command.Parameters.AddWithValue("@nome", "nome");
                        command.Parameters.AddWithValue("@sobrenome", "sobrenome");
                        command.Parameters.AddWithValue("@telefone", "telefone");
                        command.Parameters.AddWithValue("@email", "email");
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                const string message = ("Error updating contato. ");
                Console.WriteLine(message + ex);
            }
            
        }
        public void DeleteContatos(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM contatos WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                const string message = ("Error deleting contato. ");
                Console.WriteLine(message + ex);
            }
            
        }
    }
    
}

