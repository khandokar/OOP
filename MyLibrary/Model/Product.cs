using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Model
{
  public class Product : Entity
  {
    private string name;
    public string Name { get => name; set => name = value; }
  }
}
