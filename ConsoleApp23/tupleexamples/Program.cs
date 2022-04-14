using tupleexamples;

Customer[] customers = new Customer[3];

Order[] orders = new Order[3];
Customer customer1 = new Customer { id = 1, name = "hell", address = "broo" };
Customer customer2 = new Customer { id = 2, name = "ahell", address = "abroo" };
Customer customer3 = new Customer { id = 3, name = "wqeqell", address = "weqebroo" };

Order order1 = new Order
{
    id = 1,
    CustomerId = 1,
    OrderDate = new DateTime(2022, 3, 10),
    TotalAmount = 2131
};
Order order2 = new Order
{
    id = 2,
    CustomerId = 2,
    OrderDate = new DateTime(2022, 3, 10),
    TotalAmount = 2131
};
Order order3 = new Order
{
    id =3,
    CustomerId =3 ,
    OrderDate = new DateTime(2022, 3, 10),
    TotalAmount = 231
};

customers[0] = customer1;
customers[1] = customer2;
customers[2] = customer3;

orders[0] = order1;
orders[1] = order2;
orders[2] = order3;

(string, double)[] data = new (string, double)[3];
int index = 0;


for(int i=0;i < orders.Length ;i++)
{

    if(orders[i].TotalAmount>500)
    {
        for(int j=0; j<customers.Length;j++)
        {
            if(orders[i].CustomerId==customers[j].id)
            {
                data[index++] = (customers[j].name, orders[i].TotalAmount);
                
            }
        }
    }

}

for(int i=0;i<index;i++)
{
    Console.WriteLine($"Name: {data[i].Item1} ,totalamount: {data[i].Item2}");
}





