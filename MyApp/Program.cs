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

      Orderhead orderhead = new Orderhead();
      orderhead.AddLine(new Orderline { ItemId = 1, Price = 100, Qty = 5 });
      orderhead.AddLine(1, 100, 5);

      Entity customer = new Customer() { Name = "Sabbir", Email = "ss@gmail.com", Phone = "123" };
      DataAccess dataAccess = DataAccessFactory.Create(DataSourceType.MongoDB);
      dataAccess.Save(customer);

      Console.WriteLine(customer.Id);
      Console.WriteLine(customer.CreateTime);
      Console.WriteLine(customer.IsNew);
      customer.Print();

      

    }
  }
}
