using System;

namespace MyLibrary.Model
{
  public class Customer : Entity
  {
    private string name;

    private string phone;

    private string email;

    public Customer()
    {

    }
    //~Customer()
    //{
    //  Console.WriteLine("I am going to die");
    //}

    public string Name { get => name; set => name = value; }
    public string Phone { get => phone; set => phone = value; }
    public string Email { get => email; set => email = value; }

    public override void Print()
    {
      Console.WriteLine("Id - {0}, CreateDate-{1}, Name = {2}, Phone = {3}, Email ={4}", Id, CreateTime,name,phone,email);
     
    }
  }
}
