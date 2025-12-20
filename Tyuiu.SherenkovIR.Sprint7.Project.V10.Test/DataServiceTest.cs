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

            var filteredOrders = orderManager.FilterByPrice(100, 300);

            Assert.AreEqual(1, filteredOrders.Count);
            Assert.AreEqual("Vorobiev", filteredOrders[0].LastName);
        }

    }
    
}
