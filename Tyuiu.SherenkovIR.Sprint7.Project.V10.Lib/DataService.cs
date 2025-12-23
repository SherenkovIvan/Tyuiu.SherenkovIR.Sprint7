namespace Tyuiu.SherenkovIR.Sprint7.Project.V10.Lib
{

    public class Order
    {
        public string OrderNumber { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string Index { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string OrderName { get; set; } = string.Empty;

        public decimal Price { get; set; } 

        public int Quantity { get; set; }

        public string AccountNumber { get; set; } = string.Empty;
    }

    // Класс OrderManager управляет коллекцией заказов
    public class OrderManager
    {
        // Публичное свойство для доступа к списку заказов
        public List<Order> Orders { get; set; }
        // Конструктор инициализирует пустой список заказов
        public OrderManager()
        {
            Orders = new List<Order>();
        }
        // Метод для добавления нового заказа в коллекцию
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        // Метод для фильтрации заказов по диапазону цен
        public List<Order> FilterByPrice(decimal minPrice, decimal maxPrice)
        {
            Console.WriteLine($"FilterByPrice called: min={minPrice}, max={maxPrice}");
            Console.WriteLine($"Total orders: {Orders.Count}");
            // Отладочный вывод всех заказов с информацией о попадании в диапазон
            foreach (var order in Orders)
            {
                Console.WriteLine($"Order {order.LastName}: Price={order.Price}, InRange={order.Price >= minPrice && order.Price <= maxPrice}");
            }

            return Orders.Where(o => o.Price >= minPrice && o.Price <= maxPrice).ToList();
        }
        // Метод для поиска заказов по имени клиента
        public List<Order> SearchByClientName(string clientName)
        {
            // Если строка поиска пуста или содержит только пробелы, возвращаем пустой список
            if (string.IsNullOrWhiteSpace(clientName))
            {
                return new List<Order>(); 
            }
            return Orders.Where(o =>               
                (o.LastName != null && o.LastName.Contains(clientName, StringComparison.OrdinalIgnoreCase)) ||
                (o.FirstName != null && o.FirstName.Contains(clientName, StringComparison.OrdinalIgnoreCase)) ||
                (o.MiddleName != null && o.MiddleName.Contains(clientName, StringComparison.OrdinalIgnoreCase))).ToList();
        }
        // Метод для сортировки заказов по цене (по возрастанию)
        public void SortByPrice()
        {
            Orders = Orders.OrderBy(o => o.Price).ToList();
        }
        // Возвращает данные с общей стоимостью, средней стоимостью, минимальной и максимальной стоимостью
        public (decimal TotalCost, decimal AverageCost, decimal MinCost, decimal MaxCost) GetStatistics()
        {
            var totalCost = Orders.Sum(o => o.Price * o.Quantity);
            var averageCost = Orders.Average(o => o.Price * o.Quantity);
            var minCost = Orders.Min(o => o.Price * o.Quantity);
            var maxCost = Orders.Max(o => o.Price * o.Quantity);
            return (totalCost, averageCost, minCost, maxCost);
        }
        // Метод для удаления заказа из коллекции
        public bool RemoveOrder(Order orderToRemove)
        {
            if (orderToRemove == null) return false;

            Console.WriteLine($"Attempting to remove order: {orderToRemove.OrderNumber}");
            Console.WriteLine($"Orders before removal: {Orders.Count}");

            bool removed = Orders.Remove(orderToRemove);

            Console.WriteLine($"Removal successful: {removed}");
            Console.WriteLine($"Orders after removal: {Orders.Count}");

            return removed;
        }
    }

    // Класс CSVManager отвечает за работу с CSV файлами
    public class CSVManager
    {
        public void SaveToCSV(List<Order> orders, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("OrderNumber,LastName,FirstName,MiddleName,Index,City,Address,PhoneNumber,OrderName,Price,Quantity,AccountNumber");
                foreach (var order in orders)
                {
                    writer.WriteLine($"{order.OrderNumber},{order.LastName},{order.FirstName},{order.MiddleName},{order.Index},{order.City},{order.Address},{order.PhoneNumber},{order.OrderName},{order.Price},{order.Quantity},{order.AccountNumber}");
                }
            }
        }

        // Метод загрузки списка заказов из CSV файла
        public List<Order> LoadFromCSV(string filePath)
        {
            var orders = new List<Order>();

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    reader.ReadLine();

                    // Чтение файла построчно до конца
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        // Пропускаем пустые строки
                        if (string.IsNullOrEmpty(line)) continue;
                        // Разделяем строку по запятым
                        var values = line.Split(',');
                        // Проверяем количество столбцов (должно быть 12)
                        if (values.Length != 12)
                        {
                            throw new Exception("Неверное количество столбцов в файле.");
                        }
                        // Создаем объект Order и заполняем его свойства
                        var order = new Order
                        {
                            OrderNumber = values[0],
                            LastName = values[1],
                            FirstName = values[2],
                            MiddleName = values[3],
                            Index = values[4],
                            City = values[5],
                            Address = values[6],
                            PhoneNumber = values[7],
                            OrderName = values[8],
                            Price = decimal.Parse(values[9]),
                            Quantity = int.Parse(values[10]),
                            AccountNumber = values[11]
                        };
                        // Добавляем заказ в список
                        orders.Add(order);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading CSV file: {ex.Message}");
            }
            return orders;
        }
    }

}
