using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.DataAccess
{
  public abstract class DataAccess 
  {
    public abstract void Save(Entity e);

    public abstract List<Entity> GetAll();

    public abstract void Delete(Entity e);
  }
}
