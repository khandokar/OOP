using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Model
{
  public class Product : Entity
  {
    public Product()
    {

    }

    public Product(int id, DateTime createTime) : base(id, createTime)
    {

    }

    private string name;
    public string Name { get => name; set => name = value; }
  }
}
