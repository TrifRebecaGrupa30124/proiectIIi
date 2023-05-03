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
            throw new NotImplementedException();
        }

        public void Edit(ModelLogIn petModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ModelLogIn> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
