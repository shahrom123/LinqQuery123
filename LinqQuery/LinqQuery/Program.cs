
////////////////////////////////////////////////////////////////////////
// Task 1
//int[] numbers = { 1, 5, 8, 12, 15, 20 };

//var number = numbers.Select(x => x).Where(x => x > 10);

//foreach (var num in number)
//{
//    Console.WriteLine(num);

//}

////////////////////////////////////////////////////////////////////////


// Task 2
//int[] numbers = { 1, 5, 8, 12, 15, 20 };
//var number = numbers.Select(x => x).Where(x => x %2 != 0).Sum();

//  Console.WriteLine(number);

////////////////////////////////////////////////////////////////////////


// Task 3

//string[] names = { "Alice", "Anny", "Amy", "Dave", "Alex" };

//var name = names.Select(x => x).Where(x => x.StartsWith("A") && x.EndsWith("A"));

//foreach (var n in name)
//{
//    Console.WriteLine(n);

//}

///////////////////////////////////////////////////////////////////////////////

// Task 4

//int[] numbers = { 5, 8, 12, 15, 20, 25, 30 };

//var  number =  numbers.Select(x => x).OrderDescending().Take(3); 
//foreach (var item in number)
//{
//    Console.WriteLine(item);

//}


////////////////////////////////////////////////////////////////


// Task 5
//string[] words = { "apple", "banana", "cherry", "date", "elderberry" };

//var word = words.OrderByDescending(x=>x.Length);  

//foreach (var item in word)
//{
//    Console.WriteLine(item);    

//}

/////////////////////////////////////////////////////////////////

using LinqQuery;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

// Task 6

//List<Employee> employees = new List<Employee> 
//{
// new Employee { Name = "Alice", Department = "Sales", Salary = 50000 },
// new Employee { Name = "Bob", Department = "IT", Salary = 60000 },
// new Employee { Name = "Charlie", Department = "Sales", Salary = 55000 },
// new Employee { Name = "Dave", Department = "IT", Salary = 65000 },
// new Employee { Name = "Eve", Department = "HR", Salary = 45000 }
//};

//var avaregeSalary = employees.Select(x => x.Salary).Average();

//Console.WriteLine(avaregeSalary);


////////////////////////////////////////////////////////

//Task 7
//List<Person> people = new List<Person>
//{
// new Person { Name = "Alice", Age = 20 },
// new Person { Name = "Bob", Age = 30 },
// new Person { Name = "Charlie", Age = 20 },
// new Person { Name = "Dave", Age = 30 },
// new Person { Name = "Eve", Age = 20 }
//};

//var ageGroup = (from p in people
//                group p by p.Age into g
//                select g).ToList();


//foreach (var ageG in ageGroup)
//{
//    Console.WriteLine(ageG.Key);
//    foreach (var age in ageGroup)
//    {
//        Console.WriteLine(age);

//    }
//}

///////////////////////////////////////////////////////////////



// Task 8

//var customers = new List<Customer>
//{
// new Customer { Id = 1, Name = "Alice" },
// new Customer { Id = 2, Name = "Bob" },
// new Customer { Id = 3, Name = "Charlie" }, 
//}; 
//var orders = new List<Order>
//{
// new Order { OrderId = 1, CustomerId = 1, Amount = 10 },
// new Order { OrderId = 2, CustomerId = 2, Amount = 20 },
// new Order { OrderId = 3, CustomerId = 1, Amount = 30 },
// new Order { OrderId = 4, CustomerId = 3, Amount = 40 },
// new Order { OrderId = 5, CustomerId = 2, Amount = 50 },
// new Order { OrderId = 6, CustomerId = 1, Amount = 60 },
//};


//var customerOrderSums = (from o in orders
//                        join c in customers 
//                        on o.CustomerId equals c.Id
//                        group o by c.Name into g
//                        orderby g.Sum(o => o.Amount) descending 

//                        select new
//                        {
//                            CustomerName = g.Key,
//                            TotalAmount = g.Sum(o => o.Amount),
//                        }).Take(2).ToList();

//foreach (var item in customerOrderSums)
//{
//    Console.WriteLine(item);

//}





