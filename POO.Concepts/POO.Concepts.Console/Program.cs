using POO.Concepts.Core;

try
    {
    var employee1 = new SalaryEmployee { Id = 1010, FirstName = "Sandra", LastName = "Lopez", BornDate = new Date(1980, 12, 2), HireDate = new Date(2023, 2, 12), IsActive = true, Salary = 2315544.67698M };
    var employee2 = new HourlyEmployee { Id = 2020, FirstName = "Hector", LastName = "Rosales", BornDate = new Date(1974, 09, 21), HireDate = new Date(2023, 2, 12), IsActive = true, HourValue = 34679, WorkingHours = 127 };
    var employee3 = new CommisionEmployee { Id = 3030, FirstName = "Vanesa", LastName = "Zapata", BornDate = new Date(1984, 4, 11), HireDate = new Date(2023, 11, 1), IsActive = true, CommissionPercentaje = 0.03f, Sales = 527000000 };
    var employee4 = new BaseCommisionEmployee { Id = 4040, FirstName = "Pedro", LastName = "Salazar", BornDate = new Date(1984, 4, 11), HireDate = new Date(2023, 11, 1), IsActive = true, CommissionPercentaje = 0.015f, Sales = 89568000, Salary = 500000 };

    var invoice1 = new Invoice { Id = 1, Description = "Computer Asus R55",  Price = 4500000, Quantity = 3 };
    var invoice2 = new Invoice { Id = 2, Description = "Avocate", Price = 5321, Quantity = 5.68f };
    var invoice3 = new Invoice { Id = 3, Description = "Chair", Price = 823456, Quantity = 5 };

    var items = new List<IPay> { employee1, employee2, employee3, employee4, invoice1, invoice2, invoice3 };
    decimal total = 0;
    foreach (var item in items)
    {
        Console.WriteLine(item);
        Console.WriteLine();
        total += item.GetValueToPay();
    }
    Console.WriteLine("                         ====================");
    Console.WriteLine($"TOTAL:                   {total,20:C2}");


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw;
}

