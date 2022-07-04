using CSharpClasses;

var customer = new Customer();
var order = new Order();
customer.Orders = new List<Order> { order };
Console.WriteLine(customer.Id);
Console.WriteLine(customer.Name);
