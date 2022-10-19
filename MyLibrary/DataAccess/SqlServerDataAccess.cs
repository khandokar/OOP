using MyLibrary.Model;
using System;
using System.Collections.Generic;

namespace MyLibrary.DataAccess
{
  internal class SqlServerDataAccess : DataAccess
  {
    public override void Delete(Entity e)
    {
      Console.WriteLine("Delete from MySqlServer");
    }

    public override void Save(Entity e)
    {
      Console.WriteLine("Save to MySqlServer");
    }

    public override List<Entity> GetAll(Entity e)
    {
      Console.WriteLine("All from MySqlServer");
      return new List<Entity>();
    }

    public Entity ReaderToEntity()
    {
      return new Entity();
    }
  }
}
