using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.DataAccess.SqlServer
{
  public class CustomerRepostory<Customer> : IRepsitory<Customer>
  {
    public int Delete(int id)
    {
      throw new NotImplementedException();
    }

    public List<Customer> GetAll()
    {
      throw new NotImplementedException();
    }

    public List<Customer> GetAll(string whereClause = "")
    {
      throw new NotImplementedException();
    }

    public Customer GetById(int id)
    {
      throw new NotImplementedException();
    }

    public int GetCount(string whereClause = "")
    {
      throw new NotImplementedException();
    }

    public int Save(Customer customer)
    {
      throw new NotImplementedException();
    }

  }
}
