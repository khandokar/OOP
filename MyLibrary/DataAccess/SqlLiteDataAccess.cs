using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.DataAccess
{
  internal class SqlLiteDataAccess : DataAccess
  {
    public override void Delete(Entity e)
    {
      Console.WriteLine("Delete from SqlLite");
    }

    public override void Save(Entity e)
    {
      Console.WriteLine("Save to SqlLite");
    }

    public override List<Entity> GetAll()
    {
      Console.WriteLine("Update to SqlLite");
      throw new NotImplementedException();
    }
  }
}
