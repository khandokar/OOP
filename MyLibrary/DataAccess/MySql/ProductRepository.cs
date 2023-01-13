using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.DataAccess.MySql
{
  internal class ProductRepository : IRepsitory<Product>
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

    public int Save(Product t)
    {
      throw new NotImplementedException();
    }
  }
}
