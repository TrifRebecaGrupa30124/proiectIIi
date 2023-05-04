﻿using BeautyApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Repositories
{
    class BasketRepository : BaseRepository, IBasketRepository
    {
        public BasketRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //Methods
        public IEnumerable<BasketModel> GetAll()
        {
            var productList = new List<BasketModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Product order by Product_Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new BasketModel();
                        productModel.Id = (int)reader[0];
                        productModel.Name = reader[1].ToString();
                        productModel.Description = reader[2].ToString();
                        productModel.Price = reader[3].ToString();
                        productModel.Ammount = reader[4].ToString();
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public void Add(BasketModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Basket values (@name, @description, @price,@ammount)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = productModel.Description;
                command.Parameters.Add("@price", SqlDbType.NVarChar).Value = productModel.Price;
                command.Parameters.Add("@ammount", SqlDbType.NVarChar).Value = productModel.Ammount;
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
                command.CommandText = "delete from Basket where Product_Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }
        public void Edit(BasketModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Basket 
                                    set Product_Name=@name,Product_Descriere= @description,Product_Pret= @price,Product_Cantitate= @ammount
                                    where Product_Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = productModel.Description;
                command.Parameters.Add("@price", SqlDbType.NVarChar).Value = productModel.Price;
                command.Parameters.Add("@ammount", SqlDbType.NVarChar).Value = productModel.Ammount;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.Id;
                command.ExecuteNonQuery();
            }
        }
    }
}
