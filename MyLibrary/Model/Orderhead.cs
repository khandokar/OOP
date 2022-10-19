using System;
using System.Collections.Generic;

namespace MyLibrary.Model
{
  public class Orderhead : Entity
  {
    #region Fields

    private string customerId;

    private decimal total;

    private List<Orderline> orderlines;

    #endregion

    #region Contruction & Destruction

    public Orderhead()
    {
      orderlines = new List<Orderline>();
    }

    ~Orderhead()
    {
      
    }

    #endregion

    #region Property

    public string CustomerId { get => customerId; set => customerId = value; }
    
    public decimal Total { get => total; }


    #endregion

    #region Method
   
    public void AddLine(Orderline o)
    {
      orderlines.Add(o);
      RecalculateTotal();
    }

    public void AddLine(int itemId, decimal qty, decimal price)
    {
      Orderline o = new Orderline();
      o.ItemId = itemId;
      o.Qty = qty;
      o.Price = price;
      orderlines.Add(o);
    }

    public void RemoveLine(int itemId)
    {
      Orderline o = orderlines.Find(x => x.ItemId == itemId);
      if(o != null)
      {
        orderlines.Remove(o);
        RecalculateTotal();
      }
    }

    private void RecalculateTotal()
    {
      decimal t = 0;
      foreach(Orderline o in orderlines)
      {
        t = t + (o.Price * o.Qty);
        //t += (o.Price * o.Qty);
      }
      total = total + t;
      //total += t;
    }

    public override void Print()
    {
      Console.WriteLine("Id - {0}, CreateDate-{1}, CustomerId = {2}", Id, CreateTime, customerId);
    }

    #endregion 

  }
}
