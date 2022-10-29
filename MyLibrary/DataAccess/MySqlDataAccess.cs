using MyLibrary.DataAccess.MySql;
using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.DataAccess
{
  internal class MySqlDataAccess : DataAccess
  {
    private IRepsitory<T> GetRepository<T>()
    {
      var type = typeof(T);
      var repsitory  = Activator.CreateInstance("MyLibrary", string.Format("MyLibrary.DataAccess.MySql.{0}Repository", type.Name)).Unwrap() as IRepsitory<T>;
      if (repsitory == null)
        throw new Exception("Failed to find the repository " + string.Format("MyLibrary.DataAccess.MySql.{0}Repository", type.Name));
      return repsitory;
    }

    public override int Delete<T>(int id)
    {
      var repository = GetRepository<T>();
      return repository.Delete(id);
    }

    public override int Save<T>(T e)
    {
      var repository = GetRepository<T>();
      return repository.Save(e);
    }

    public override List<T> GetAll<T>(string whereClause = "")
    {      
      var repository = GetRepository<T>();
      return repository.GetAll(whereClause);
    }

    public override T GetById<T>(int id)
    {
      var repository = GetRepository<T>();
      return repository.GetById(id);
    }

    public override int GetCount<T>(string whereClause = "")
    {
      var repository = GetRepository<T>();
      return repository.GetCount(whereClause);
    }
  }
}
