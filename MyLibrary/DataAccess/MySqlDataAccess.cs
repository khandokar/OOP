using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.DataAccess
{
  internal class MySqlDataAccess : DataAccess
  {
    public override void Delete(Entity e)
    {
      Console.WriteLine("Delete from MySql");
    }

    public override void Save(Entity e)
    {
      Console.WriteLine("Save to MySql");
    }

    public override List<Entity> GetAll()
    {
      Console.WriteLine("All from MySql");
      return new List<Entity>();
    }
  }
}
