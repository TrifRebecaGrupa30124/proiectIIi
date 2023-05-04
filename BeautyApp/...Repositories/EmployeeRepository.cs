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
    class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //Methods
        public IEnumerable<EmployeeModel> GetAll()
        {
            var employeeList = new List<EmployeeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Employees order by Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var employeeModel = new EmployeeModel();
                        employeeModel.Id = (int)reader[0];
                        employeeModel.Name = reader[1].ToString();
                        employeeModel.JobName = reader[2].ToString();
                        employeeModel.HireDate = reader[3].ToString();
                        employeeModel.Salary = reader[4].ToString();
                        employeeModel.Email = reader[5].ToString();
                        employeeModel.Sex = reader[6].ToString();
                        employeeModel.Phone = reader[7].ToString();
                        employeeModel.BirthDate_ = reader[8].ToString();

                        employeeList.Add(employeeModel);
                    }
                }
            }
            return employeeList;
        }
        public IEnumerable<EmployeeModel> GetByValue(string value)
        {
            var employeeList = new List<EmployeeModel>();
            int employeeId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string employeeName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from Employees
                                        where Id=@id or Name like @name+'%' 
                                        order by Id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = employeeId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employeeName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var employeeModel = new EmployeeModel();
                        employeeModel.Id = (int)reader[0];
                        employeeModel.Name = reader[1].ToString();
                        employeeModel.JobName = reader[2].ToString();
                        employeeModel.HireDate = reader[3].ToString();
                        employeeModel.Salary = reader[4].ToString();
                        employeeModel.Email = reader[5].ToString();
                        employeeModel.Sex = reader[6].ToString();
                        employeeModel.Phone = reader[7].ToString();
                        employeeModel.BirthDate_ = reader[8].ToString();
                        employeeList.Add(employeeModel);
                    }
                }
            }
            return employeeList;
        }
        public void Add(EmployeeModel employeeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Employees values (@id, @name, @jobname,@hiredate,@salary,@email,@sex,@phone,@birthdate)";
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = employeeModel.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employeeModel.Name;
                command.Parameters.Add("@jobname", SqlDbType.NVarChar).Value = employeeModel.JobName;
                command.Parameters.Add("@hiredate", SqlDbType.NVarChar).Value = employeeModel.HireDate;
                command.Parameters.Add("@salary", SqlDbType.NVarChar).Value = employeeModel.Salary;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = employeeModel.Email;
                command.Parameters.Add("@sex", SqlDbType.NVarChar).Value = employeeModel.Sex;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = employeeModel.Phone;
                command.Parameters.Add("@birthdate", SqlDbType.NVarChar).Value = employeeModel.BirthDate_;
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
                command.CommandText = "delete from Employees where Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }
        public void Edit(EmployeeModel employeeModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Employees 
                                    set Name=@name,Job_Name= @jobname,Hire_Date= @hiredate,Salary= @salary,Email = @email, Sex = @sex, Phone = @phone, Birth_Date = @birthdate
                                    where Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = employeeModel.Name;
                command.Parameters.Add("@jobname", SqlDbType.NVarChar).Value = employeeModel.JobName;
                command.Parameters.Add("@hiredate", SqlDbType.NVarChar).Value = employeeModel.HireDate;
                command.Parameters.Add("@salary", SqlDbType.NVarChar).Value = employeeModel.Salary;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = employeeModel.Email;
                command.Parameters.Add("@sex", SqlDbType.NVarChar).Value = employeeModel.Sex;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = employeeModel.Phone;
                command.Parameters.Add("@birthdate", SqlDbType.NVarChar).Value = employeeModel.BirthDate_;

                command.ExecuteNonQuery();
            }
        }
    }
}
