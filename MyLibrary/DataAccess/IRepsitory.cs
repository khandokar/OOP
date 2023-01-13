using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.DataAccess
{
  internal interface IRepsitory<T> 
  {
    int Save(T t); 
    int Delete(int id);
    List<T> GetAll(string whereClause = "");
    T GetById(int id);
    int GetCount(string whereClause = "");
  }
}
