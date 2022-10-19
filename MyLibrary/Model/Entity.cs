using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Model
{
  public class Entity
  {
    private int id;

    public int Id
    {
      get
      {
        return id;
      }
    }

    private DateTime createTime;

    public Entity()
    {
      createTime = new DateTime();
    }

    public bool IsNew
    {
      get
      {
        return id <= 0;
      }
    }

    public DateTime CreateTime { get => createTime; }

    public virtual void Print()
    {
      Console.WriteLine("Id - {0}, CreateDate-{1}", id, createTime);
    }

  }
}
