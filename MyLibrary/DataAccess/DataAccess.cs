using System.Collections.Generic;

namespace MyLibrary.DataAccess
{
  public abstract class DataAccess 
  {
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="t"></param>
    /// <returns>Id of the saved object</returns>
    public abstract int Save<T>(T t);

    public abstract int Delete<T>(int id);

    public abstract List<T> GetAll<T>(string whereClause = "");

    public abstract T GetById<T>(int id);

    public abstract int GetCount<T>(string whereClause = "");

  }
}
