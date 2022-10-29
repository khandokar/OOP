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
      set
      {
        id = value;
      }

    }

    private DateTime createTime;

    public Entity()
    {
      this.id = 0;
      createTime = DateTime.Now;
    }

    public Entity(int id, DateTime createTime)
    {
      this.id = id;
      this.createTime = createTime;
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
