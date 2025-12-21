using Tyuiu.SherenkovIR.Sprint7.Project.V10.Lib;
namespace Tyuiu.SherenkovIR.Sprint7.Project.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFilter()
        {
            var orderManager = new OrderManager();
            orderManager.AddOrder(new Order { OrderNumber = "1", LastName = "Vorobiev", FirstName = "Sergey", MiddleName = "Leonidovich", Index = "123456", City = "Moscow", Address = "Azovskogo 6", PhoneNumber = "8952755555", OrderDate = DateTime.Now, OrderName = "ProductA", Price = 100, Quantity = 2, AccountNumber = "01" });
            orderManager.AddOrder(new Order { OrderNumber = "2", LastName = "Ivanov", FirstName = "Ivan", MiddleName = "Ivanovich", Index = "654321", City = "Tyumen", Address = "Lenina 34", PhoneNumber = "8952766666", OrderDate = DateTime.Now, OrderName = "ProductB", Price = 400, Quantity = 1, AccountNumber = "02" });
            orderManager.AddOrder(new Order { OrderNumber = "3", LastName = "Petrov", FirstName = "Petr", MiddleName = "Petro]vich", Index = "654312", City = "St.Peterburg", Address = "Precgistenka 8", PhoneNumber = "8952766667", OrderDate = DateTime.Now, OrderName = "ProductC", Price = 250, Quantity = 3, AccountNumber = "03" });
            orderManager.AddOrder(new Order { OrderNumber = "4", LastName = "Shevchenko", FirstName = "Mark", MiddleName = "Anatolievich", Index = "654213", City = "Megion", Address = "Lenina 2", PhoneNumber = "8952766668", OrderDate = DateTime.Now, OrderName = "ProductD", Price = 300, Quantity = 1, AccountNumber = "04" });
            orderManager.AddOrder(new Order { OrderNumber = "5", LastName = "Lenin", FirstName = "Vladimir", MiddleName = "Ivanovich", Index = "653214", City = "Vladivostok", Address = "Morozova 21", PhoneNumber = "8952766669", OrderDate = DateTime.Now, OrderName = "ProductE", Price = 600, Quantity = 2, AccountNumber = "05" });
            var filteredOrders = orderManager.FilterByPrice(100, 300);

            Console.WriteLine($"Найдено заказов: {filteredOrders.Count}");
            foreach (var order in filteredOrders)
            {
                Console.WriteLine($"- {order.LastName}: {order.Price}");
            }

            var lastNames = filteredOrders.Select(o => o.LastName).ToList();
            Assert.IsTrue(lastNames.Contains("Vorobiev"));
            Assert.IsTrue(lastNames.Contains("Petrov"));
            Assert.IsTrue(lastNames.Contains("Shevchenko"));

            Assert.IsFalse(lastNames.Contains("Ivanov"));
            Assert.IsFalse(lastNames.Contains("Lenin"));
        }

    }
    
}
