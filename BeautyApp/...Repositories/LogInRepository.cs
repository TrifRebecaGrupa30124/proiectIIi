using BeautyApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Repositories
{
    class LogInRepository : BaseRepository, ILogInRepository
    {
        public LogInRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ModelLogIn logInModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Admin values (@name, @password)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = logInModel.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = logInModel.Password;

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Admin where Admin_id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }


        }

        public void Edit(ModelLogIn logInModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Admin 
                                    set Admin_Name=@name,Admin_Parola= @password
                                    where Admin_Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = logInModel.Name;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = logInModel.Password;

                command.Parameters.Add("@id", SqlDbType.Int).Value = logInModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public ModelLogIn GetAll()
        {
            var adminList = new ModelLogIn();
            //var adminList = new ModelLogIn();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Admin order by Admin_Id";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        adminList.Id = (int)reader[0];
                        adminList.Name = reader[1].ToString();
                        adminList.Password = reader[2].ToString();

                    }
                }
            }
            return adminList;
        }
    }
}
