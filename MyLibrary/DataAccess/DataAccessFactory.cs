using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.DataAccess
{
  public class DataAccessFactory
  {
    public static DataAccess Create(DataSourceType dataSourceType)
    {
      DataAccess dataAccess;
      switch (dataSourceType)
      {
        case DataSourceType.SqlServer:
          dataAccess = new SqlServerDataAccess();
          break;
        case DataSourceType.MySql:
          dataAccess = new MySqlDataAccess();
          break;
        case DataSourceType.SqlLite:
          dataAccess = new SqlLiteDataAccess();
          break;
        case DataSourceType.MongoDB:
          dataAccess = new MongoDBDataAccess();
          break;
        default:
          dataAccess = new CassandraDataAccess();
          break;
      }
      return dataAccess;
    }

  }
}
