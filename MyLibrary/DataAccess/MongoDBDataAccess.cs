using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.DataAccess
{
  internal class MongoDBDataAccess : DataAccess
  {
    public override void Delete(Entity e)
    {
      Console.WriteLine("Delete from MongoDB");
    }

    public override void Save(Entity e)
    {
      Console.WriteLine("Save to MongoDB");
    }

    public override List<Entity> GetAll()
    {
      Console.WriteLine("Update to MongoDB");
      throw new NotImplementedException();
    }
  }
}
