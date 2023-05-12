using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Classes;

namespace Test.Moduls
{
    internal class DataBase
    {
        public List<File> LoadBD()
        {
            List<File> files = new List<File>();

            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "use [FileMeneger] select [Key],[FileName],[Link] from [dbo].[FileInfo]";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        files.Add(new File((int)reader[0], reader[1].ToString(), reader[2].ToString()));
                    }
                }
                reader.Close();
                return files;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return files;
            }
            finally
            {
                connection.Close();
            }

        }
        public bool SaveBD(string name)
        {
            SqlConnection connection = new SqlConnection(Connection.connString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand cmd = connection.CreateCommand();
            try
            {

                cmd.Transaction = transaction;

                cmd.CommandText = "use [FileMeneger] INSERT INTO [dbo].[FileInfo] ([Key],[FileName],[Link]) VALUES (@Key,@Name,@Link)";
                cmd.Parameters.AddWithValue("@Key", MaxKey());
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Link", StoragePlace.PlacePath + name + ".txt");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Файл добавлен в бд!");
                transaction.Commit();

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Файл с таким именем уже существует");
                return false;
            }
            finally
            {
                connection.Close();
            }

        }
        public bool SaveBD(int key, string name, string link )
        {
            SqlConnection connection = new SqlConnection(Connection.connString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand cmd = connection.CreateCommand();
            try
            {

                cmd.Transaction = transaction;

                cmd.CommandText = "use [FileMeneger] INSERT INTO [dbo].[FileInfo] ([Key],[FileName],[Link]) VALUES (@Key,@Name,@Link)";
                cmd.Parameters.AddWithValue("@Key", key);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Link", link);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Файл добавлен в бд!");
                transaction.Commit();

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Файл не попал в бд");
                return false;
            }
            finally
            {
                connection.Close();
            }

        }
        public int MaxKey()
        {
            try
            {
                SqlConnection connection = new SqlConnection(Connection.connString);
                connection.Open();
                string sqlExp = "use [FileMeneger] select max([Key]) from [dbo].[FileInfo]";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return (int)reader[0] + 1;
            }
            catch 
            {
                return 1;
            }
            
        }
        public string LoadPath(int key)
        {
            SqlConnection connection = new SqlConnection(Connection.connString);
            try
            {
                connection.Open();
                string sqlExp = "use [FileMeneger] SELECT [Link] from [dbo].[FileInfo] where [Key] = @Key group by [Link]";
                SqlCommand command = new SqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@Key", key);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader[0].ToString();
            }
            catch
            {
                
                return null;
            }
            
        }
        public void DeleteBD(string name)
        {
            SqlConnection connection = new SqlConnection(Connection.connString);
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand cmd = connection.CreateCommand();
            try
            {

                cmd.Transaction = transaction;

                cmd.CommandText = "use [FileMeneger] delete [dbo].[FileInfo] where [FileName] = @Name ";
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Файл удалён из бд!");
                transaction.Commit();
            }
            catch (Exception)
            {

                MessageBox.Show("Файл не удалён из бд");
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
