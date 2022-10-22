## Abstraction:

Abstraction is the process of reducing the complexities of a class to a few publicly accessible user interfaces. 
These public interfaces allow the user to perform useful work without the need to know its underlying complexities.

Abstract classes and interfaces can be used to implement abstraction.

Here abstract class DataAccess is used to make only the three methods to publicly accessible.

 ```
 Entity customer = new Customer() { Name = "Sabbir", Email = "ss@gmail.com", Phone = "123" };
 DataAccess dataAccess = DataAccessFactory.Create(DataSourceType.MongoDB);
 dataAccess.Save(customer);
 dataAccess.GetAll();
 dataAccess.Delete(customer);
```
## Encapsulation:

Encapsulation is the process of grouping together related data and behaviors in a single cohesive and functional class unit, 
and “hiding” sensitive data from users with the help of access modifiers.
Encapsulation can be implemented utilizing access modifiers such as private, protected, and public.

## Polymorphism:

The term "Polymorphism" is the combination of "poly" + "morphs" which means many forms. It is a greek word. 

There are two types of polymorphism, compile time polymorphism and runtime polymorphism. 
Compile time polymorphism is achieved by method overloading and operator overloading.
It is also known as static binding or early binding. Runtime polymorphism in achieved by method overriding which is also known as dynamic binding or late binding.

 1. Compile time polymorphism(Static binding or early binding)
   ```
   //Overloaded method like the following
   Orderhead orderhead = new Orderhead();
   orderhead.AddLine(new Orderline { ItemId = 1, Price = 100, Qty = 5 });
   orderhead.AddLine(1, 100, 5);
   ```
2. Runtime polymorphism(dynamic binding or late binding)
   At run time, objects of a derived class may be treated as objects of a base class in places such as method parameters and collections or arrays
  
  ```
  Entity customer = new Customer() { Name = "Sabbir", Email = "ss@gmail.com", Phone = "123" };
  //DataAccess is base type where DataAccessFactory is returning derived type
  DataAccess dataAccess = DataAccessFactory.Create(DataSourceType.MongoDB);
  dataAccess.Save(customer); //Customer(derive type) is being treated as Entry(base type) in Save
  ```

Base classes may define and implement virtual methods, and derived classes can override them, which means they provide their own definition and implementation. At run-time, when client code calls the method, the CLR looks up the run-time type of the object, and invokes that override of the virtual method 
 
  ``` 
  Entity customer = new Customer() { Name = "Saffat", Email = "ss1@gmail.com", Phone = "345" };
  customer.Print();
  // Runtime type is Customer instead of Entity 
  // and print -- Id - 0, CreateDate-10/19/2022 6:40:02 AM, Name = Saffat, Phone = 345, Email =ss1@gmail.com
  ``` 

## Inheritance:

Inheritance is a process in which one object acquires all the properties and behaviors of its parent object automatically.
In such way, you can reuse, extend or modify the attributes and behaviors which is defined in other class.

The class which inherits the members of another class is called derived class and the class whose members are inherited is called base class.
Inheritance inherits reuseability

 ``` 
// Properties and method are acquire from parent class
Customer customer = new Customer() { Name = "Saffat", Email = "ss1@gmail.com", Phone = "345" };  
Console.WriteLine(customer.Id);
Console.WriteLine(customer.CreateTime);
Console.WriteLine(customer.IsNew);
customer.Print();
 ``` 



