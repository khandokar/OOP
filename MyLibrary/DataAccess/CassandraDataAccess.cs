using MyLibrary.Model;
using System;
using System.Collections.Generic;

namespace MyLibrary.DataAccess
{
  internal class CassandraDataAccess : DataAccess
  {
    public override int Delete<T>(int id)
    {
      throw new NotImplementedException();
    }

    public override List<T> GetAll<T>(string whereClause = "")
    {
      throw new NotImplementedException();
    }

    public override T GetById<T>(int id)
    {
      throw new NotImplementedException();
    }

    public override int GetCount<T>(string whereClause = "")
    {
      throw new NotImplementedException();
    }

    public override int Save<T>(T e)
    {
      throw new NotImplementedException();
    }
  }
}
