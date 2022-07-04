using CSharpClasses;

var customer = new Customer();

var customer1 = new Customer
{
    Name = "Customer Name",
    Id = 4
};

var order = new Order();
customer.Orders = new List<Order> { order };
Console.WriteLine(customer.Id);
Console.WriteLine(customer.Name);
