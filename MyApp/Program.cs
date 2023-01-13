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
      Application.Run(new Form1());

      //Entity customer = new Customer() { Name = "Sabbir", Email = "ss@gmail.com", Phone = "123" };
      //DataAccess dataAccess = DataAccessFactory.Create(DataSourceType.MySql);
      //dataAccess.Save(customer);
      //dataAccess.GetAll<Customer>();
      //dataAccess.Delete<Customer>(customer.Id);
       
      //Orderhead orderhead = new Orderhead();
      //orderhead.AddLine(new Orderline { ProductId = 1, Price = 100, Qty = 5 });
      //orderhead.AddLine(1, 100, 5);

      //DataAccess mysqlDB = DataAccessFactory.Create(DataSourceType.MySql);

      //Customer customer = new Customer() { Name = "Meraj", Email = "meraj@gmail.com", Phone = "123" };

      //Insert
      //mysqlDB.Save(customer);

      //Update
      //customer.Phone = "345";
      // mysqlDB.Save(customer);

      //var data = dataAccess.GetById<Customer>(4);

      //var count = dataAccess.GetCount<Product>(); 

      //Console.WriteLine(customer.Id);
      //Console.WriteLine(customer.CreateTime);
      //Console.WriteLine(customer.IsNew);
      // customer.Print();


      //Product product = new Product() { Name = "Meraj"};
      //DataAccess sqlServerDB = DataAccessFactory.Create(DataSourceType.SqlServer);
      //sqlServerDB.Save(product);

      //var data = sqlServerDB.GetAll<Product>();

    }
  }
}
