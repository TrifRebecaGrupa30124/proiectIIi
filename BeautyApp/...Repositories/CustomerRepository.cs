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
    class CustomerRepository: BaseRepository, ICustomerRepository
    {
        public CustomerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //Methods
        public IEnumerable<CustomerModel> GetAll()
        {
            var customerList = new List<CustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Customers order by Customer_Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.Id = (int)reader[0];
                        customerModel.Name = reader[1].ToString();
                        customerModel.Email = reader[2].ToString();
                        customerModel.Phone = reader[3].ToString();
                        customerModel.Address = reader[4].ToString();

                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }
        public IEnumerable<CustomerModel> GetByValue(string value)
        {
            var customerList = new List<CustomerModel>();
            int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customerName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from Customers
                                        where Customer_Id=@id or Customer_Name like @name+'%' 
                                        order by Customer_Id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customerName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.Id = (int)reader[0];
                        customerModel.Name = reader[1].ToString();
                        customerModel.Email = reader[2].ToString();
                        customerModel.Phone = reader[3].ToString();
                        customerModel.Address = reader[4].ToString();

                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }
        public void Add(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Customers values (@name, @email, @phone,@address)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customerModel.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = customerModel.Email;
                command.Parameters.Add("@price", SqlDbType.NVarChar).Value = customerModel.Phone;
                command.Parameters.Add("@ammount", SqlDbType.NVarChar).Value = customerModel.Address;

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
                command.CommandText = "delete from Customers where Customer_Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }
        public void Edit(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Customers 
                                    set Customer_Name=@name,Customer_email= @email,Customer_Phone= @phone,Customer_Address= @address
                                    where Product_Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customerModel.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = customerModel.Email;
                command.Parameters.Add("@price", SqlDbType.NVarChar).Value = customerModel.Phone;
                command.Parameters.Add("@ammount", SqlDbType.NVarChar).Value = customerModel.Address;

                command.Parameters.Add("@id", SqlDbType.Int).Value = customerModel.Id;
                command.ExecuteNonQuery();
            }
        }
    }
}

