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
            orderManager.AddOrder(new Order { OrderNumber = "1", LastName = "Vorobiev", FirstName = "Sergey", MiddleName = "Leonidovich", Index = "123456", City = "Moscow", Address = "Azovskogo 6", PhoneNumber = "8952755555", OrderName = "ProductA", Price = 100, Quantity = 2, AccountNumber = "01" });
            orderManager.AddOrder(new Order { OrderNumber = "2", LastName = "Ivanov", FirstName = "Ivan", MiddleName = "Ivanovich", Index = "654321", City = "Tyumen", Address = "Lenina 34", PhoneNumber = "8952766666", OrderName = "ProductB", Price = 400, Quantity = 1, AccountNumber = "02" });
            orderManager.AddOrder(new Order { OrderNumber = "3", LastName = "Petrov", FirstName = "Petr", MiddleName = "Petrovich", Index = "654312", City = "St.Peterburg", Address = "Precgistenka 8", PhoneNumber = "8952766667", OrderName = "ProductC", Price = 250, Quantity = 3, AccountNumber = "03" });
            orderManager.AddOrder(new Order { OrderNumber = "4", LastName = "Shevchenko", FirstName = "Mark", MiddleName = "Anatolievich", Index = "654213", City = "Megion", Address = "Lenina 2", PhoneNumber = "8952766668", OrderName = "ProductD", Price = 300, Quantity = 1, AccountNumber = "04" });
            orderManager.AddOrder(new Order { OrderNumber = "5", LastName = "Lenin", FirstName = "Vladimir", MiddleName = "Ivanovich", Index = "653214", City = "Vladivostok", Address = "Morozova 21", PhoneNumber = "8952766669", OrderName = "ProductE", Price = 600, Quantity = 2, AccountNumber = "05" });
            orderManager.AddOrder(new Order { OrderNumber = "6", LastName = "Sokolov", FirstName = "Alexey", MiddleName = "Viktorovich", Index = "125487", City = "Kazan", Address = "Pushkina 15", PhoneNumber = "8952777777", OrderName = "ProductF", Price = 150, Quantity = 4, AccountNumber = "06" });
            orderManager.AddOrder(new Order { OrderNumber = "7", LastName = "Kuznetsova", FirstName = "Olga", MiddleName = "Sergeevna", Index = "354789", City = "Ekaterinburg", Address = "Mira 42", PhoneNumber = "8952788888", OrderName = "ProductG", Price = 280, Quantity = 2, AccountNumber = "07" });
            orderManager.AddOrder(new Order { OrderNumber = "8", LastName = "Morozov", FirstName = "Igor", MiddleName = "Pavlovich", Index = "987321", City = "Samara", Address = "Gagarina 11", PhoneNumber = "8952711111", OrderName = "ProductJ", Price = 200, Quantity = 3, AccountNumber = "10" });
            orderManager.AddOrder(new Order { OrderNumber = "9", LastName = "Belyaev", FirstName = "Maxim", MiddleName = "Olegovich", Index = "369258", City = "Voronezh", Address = "Pervomayskaya 5", PhoneNumber = "8952733333", OrderName = "ProductL", Price = 120, Quantity = 4, AccountNumber = "12" });
            orderManager.AddOrder(new Order { OrderNumber = "10", LastName = "Komarova", FirstName = "Svetlana", MiddleName = "Igorevna", Index = "852147", City = "Ufa", Address = "Revolyutsionnaya 8", PhoneNumber = "8952766660", OrderName = "ProductO", Price = 180, Quantity = 3, AccountNumber = "15" });

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
            Assert.IsTrue(lastNames.Contains("Sokolov"));       
            Assert.IsTrue(lastNames.Contains("Kuznetsova"));    
            Assert.IsTrue(lastNames.Contains("Morozov"));       
            Assert.IsTrue(lastNames.Contains("Belyaev"));       
            Assert.IsTrue(lastNames.Contains("Komarova"));      
            Assert.IsFalse(lastNames.Contains("Ivanov"));       
            Assert.IsFalse(lastNames.Contains("Lenin"));
            Assert.AreEqual(8, filteredOrders.Count);
        }

    }
    
}
