using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _2024_10_15_interface
{
    class dbHandler : Interface1
    {
        MySqlConnection connection;
        string tableName = "users";
        public dbHandler()
        {
            string user = "root";
            string password = "";
            string dbName = "UserDatabase";
            string host = "localhost";

            string connectionString = $"username={user};password={password};database={dbName};host={host}";

            connection = new MySqlConnection(connectionString);


        }


        public void DeleteAll()
        {
            try
            {
                connection.Open();
                string query = $"delete from {tableName}";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public void DeleteOne(user oneUser)
        {
            try
            {
                connection.Open();
                string query = $"delete from {tableName} where id={oneUser.id}";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public void InsertOne(user oneUser)
        {
            try
            {
                connection.Open();
                string query = $"insert into {tableName} (id,username,password,point) values ({oneUser.id},'{oneUser.username}','{oneUser.password}','{oneUser.point}')";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public void readAll()
        {
            try
            {
                connection.Open();
                string query = $"select * from {tableName}";
                MySqlCommand command = new MySqlCommand(query,connection);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    user oneUser = new user();
                    oneUser.id = read.GetInt32(read.GetOrdinal("id"));
                    oneUser.username = read.GetString(read.GetOrdinal("username"));
                    oneUser.password = read.GetString(read.GetOrdinal("password"));
                    oneUser.point = read.GetInt32(read.GetOrdinal("point"));
                    user.allUser.Add(oneUser);

                }
                read.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public void UpdateOne(user oneUser)
        {
            try
            {
                connection.Open();
                string query = $"update {tableName} set point = {oneUser.point} where id = {oneUser.id}";
                MySqlCommand command = new MySqlCommand();
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
    }
}
