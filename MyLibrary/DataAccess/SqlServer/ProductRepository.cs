using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MyLibrary.DataAccess.SqlServer
{
  public class ProductRepository : IRepsitory<Product>
  {
    public int Delete(int id)
    {
      throw new NotImplementedException();
    }

    public List<Product> GetAll(string whereClause = "")
    {
      throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
      throw new NotImplementedException();
    }

    public int GetCount(string whereClause = "")
    {
      throw new NotImplementedException();
    }

    public int Save(Product product)
    {
      int primaryKey = 0;
      var myConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
      SqlConnection conn = new SqlConnection();
      try
      {
        conn.ConnectionString = myConnectionString;
        conn.Open();

        SqlCommand comm = conn.CreateCommand();

        if (product.IsNew)
        {
          comm.CommandText = "INSERT INTO Product(CreateTime,Name) VALUES(@CreateTime, @Name); SELECT SCOPE_IDENTITY()";
          comm.Parameters.Add("@CreateTime", SqlDbType.DateTime).Value = DateTime.Today;
        }
        else
        {
          comm.CommandText = "Update Product SET Name = @Name WHERE Id = @Id";
          comm.Parameters.Add("@Id", SqlDbType.Int).Value = product.Id;
        }
        comm.Parameters.Add("@Name", SqlDbType.VarChar).Value = product.Name;
        if (product.IsNew)
        {
          primaryKey = Convert.ToInt32(comm.ExecuteScalar());
          product.Id = primaryKey;
        }
        else
        {
          comm.ExecuteNonQuery();
          primaryKey = product.Id;
        }
      }
      catch (SqlException ex)
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
