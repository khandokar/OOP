namespace MyLibrary.Model
{
  public class Orderline : Entity
  {

    #region Fields

    private int itemId;

    private decimal qty;

    private decimal price;

    private decimal total;

    #endregion

    #region Contruction & Destruction
    
    public Orderline()
    {

    }

    ~Orderline()
    {

    }

    #endregion

    #region Property
    
    public int ItemId { get => itemId; set => itemId = value; }
    
    public decimal Qty
    {
      get
      {
        return qty;
      }
      set
      {
        qty = value;
        CalculateTotal();
      }
    }

    public decimal Price 
    { 
      get
      {
        return price;
      }
      set
      {
        price = value;
        CalculateTotal();
      }
    }
    
    public decimal Total { get => total;}

    #endregion

    #region Method
    
    private void CalculateTotal()
    {
      total = price * qty;
    }

    #endregion
  }
}
