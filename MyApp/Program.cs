using System;
using System.Windows.Forms;
using MyLibrary.DataAccess;
using MyLibrary;
using MyLibrary.Model;

namespace WinFormsApp1
{
  static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.SetHighDpiMode(HighDpiMode.SystemAware);
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //Application.Run(new Form1());

      Entity orderhead = new Orderhead();
      orderhead.Print();

      Customer customer = new Customer();

      DataAccess dataAccess = DataAccessFactory.Create(DataSourceType.MongoDB);
 

      dataAccess.Save(customer);

      dataAccess = DataAccessFactory.Create(DataSourceType.Mysql);

      dataAccess.Save(customer);
    }
  }
}
