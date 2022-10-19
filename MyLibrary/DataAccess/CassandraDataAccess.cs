using MyLibrary.Model;
using System;
using System.Collections.Generic;

namespace MyLibrary.DataAccess
{
  internal class CassandraDataAccess : DataAccess
  {
    public override void Delete(Entity e)
    {
      Console.WriteLine("Delete from Cassandra");
    }

    public override List<Entity> GetAll(Entity e)
    {
      Console.WriteLine("All from Cassandra");
      return new List<Entity>(); 
    }

    public override void Save(Entity e)
    {
      Console.WriteLine("Save to Cassandra");
    }
  }
}
