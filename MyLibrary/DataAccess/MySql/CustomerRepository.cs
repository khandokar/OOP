using MyLibrary.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace MyLibrary.DataAccess.MySql
{
  internal class CustomerRepository : IRepsitory<Customer>
  {
    public int Delete(int id) 
    {
      int noOfRowAffected = 0;
      var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
      MySqlConnection conn = new MySqlConnection();     
      try
      {
        conn.ConnectionString = myConnectionString;
        conn.Open();

        MySqlCommand comm = conn.CreateCommand();
        comm.CommandText = "Delete from Customer where Id = " + id.ToString();
        var obj = comm.ExecuteNonQuery();
        noOfRowAffected = Convert.ToInt32(obj);
      }
      catch (MySqlException ex)
      {
        throw ex;
      }
      finally
      {
        conn.Close();
      }
      return noOfRowAffected;
    }

    public List<Customer> GetAll(string whereClause)
    {
      var customers = new List<Customer>();
      var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
      MySqlConnection conn = new MySqlConnection();
      if (!string.IsNullOrEmpty(whereClause))
      {
        whereClause = " Where " + whereClause;
      }
      try
      {
        conn.ConnectionString = myConnectionString;
        conn.Open();

        MySqlCommand comm = conn.CreateCommand();
        comm.CommandText = "Select * from Customer" + whereClause;
        using (MySqlDataReader reader = comm.ExecuteReader())
        {
          while (reader != null && reader.Read())
          {
            int id = Convert.ToInt32(reader["id"]);
            DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
            var customer = new Customer(id, createTime);
            customer.Name = reader["Name"].ToString();
            customer.Phone = reader["Phone"] is DBNull ? null : reader["Phone"].ToString();
            customer.Email = reader["Email"] is DBNull ? null : reader["Email"].ToString();
            customers.Add(customer);
          }
        }

      }
      catch (MySqlException ex)
      {
        throw ex;
      }
      finally
      {
        conn.Close();
      }
      return customers;
    }

    public Customer GetById(int id)
    {
      var customer = new Customer();
      var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
      MySqlConnection conn = new MySqlConnection();
     
      try
      {
        conn.ConnectionString = myConnectionString;
        conn.Open();

        MySqlCommand comm = conn.CreateCommand();
        comm.CommandText = "Select * from Customer where Id = " + id.ToString();
        using (MySqlDataReader reader = comm.ExecuteReader())
        {
          if(reader != null && reader.Read())
          {
            int sid = Convert.ToInt32(reader["Id"]);
            DateTime createTime = Convert.ToDateTime(reader["CreateTime"]);
            customer = new Customer(id, createTime);
            customer.Name = reader["Name"].ToString();
            customer.Phone = reader["Phone"] is DBNull ? null : reader["Phone"].ToString();
            customer.Email = reader["Email"] is DBNull ? null : reader["Email"].ToString();
          }
        }

      }
      catch (MySqlException ex)
      {
        throw ex;
      }
      finally
      {
        conn.Close();
      }
      return customer;
    }

    public int GetCount(string whereClause)
    {
      int count = 0;
      var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
      MySqlConnection conn = new MySqlConnection();
      if(!string.IsNullOrEmpty(whereClause))
      {
        whereClause = " Where " + whereClause;
      }
      try
      {
        conn.ConnectionString = myConnectionString;
        conn.Open();

        MySqlCommand comm = conn.CreateCommand();
        comm.CommandText = "Select Count(*) from Customer"+whereClause;
        var obj = comm.ExecuteScalar();
        count = Convert.ToInt32(obj);
      }
      catch (MySqlException ex)
      {
        throw ex;
      }
      finally
      {
        conn.Close();
      }
      return count;
    }

    public int Save(Customer customer)
    {
      int primaryKey = 0;
      var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
      MySqlConnection conn = new MySqlConnection();
      try
      {
        conn.ConnectionString = myConnectionString;
        conn.Open();

        MySqlCommand comm = conn.CreateCommand();

        if (customer.IsNew)
        {
          comm.CommandText = "INSERT INTO Customer(CreateTime,Name,Phone,Email) VALUES(@CreateTime, @Name, @Phone, @Email); SELECT LAST_INSERT_ID()";
          comm.Parameters.Add("@CreateTime", DbType.DateTime).Value = DateTime.Today;        
        }
        else
        {
          comm.CommandText = "Update Customer SET Name = @Name, Phone = @Phone, Email = @Email WHERE Id = @Id";
          comm.Parameters.Add("@Id", DbType.Int32).Value = customer.Id;
        }
        comm.Parameters.Add("@Name", DbType.String).Value = customer.Name;
        comm.Parameters.Add("@Phone", DbType.String).Value = customer.Phone;
        comm.Parameters.Add("@Email", DbType.String).Value = customer.Email;
        if(customer.IsNew)
        {
          primaryKey = Convert.ToInt32(comm.ExecuteScalar());
          customer.Id = primaryKey;
        }
        else
        {
          comm.ExecuteNonQuery();
          primaryKey = customer.Id;
        }
      }
      catch (MySqlException ex)
      {
        throw ex;
      }
      finally
      {
        conn.Close();
      }
      return primaryKey;
    }
  }
}
