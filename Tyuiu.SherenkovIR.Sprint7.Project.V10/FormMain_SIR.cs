using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SherenkovIR.Sprint7.Project.V10.Lib;
namespace Tyuiu.SherenkovIR.Sprint7.Project.V10
{
    public partial class FormMain_SIR : Form
    {
        private OrderManager orderManager; // Менеджер для работы с заказами
        private CSVManager csvManager; // Менеджер для работы с CSV файлами
        public FormMain_SIR()
        {
            InitializeComponent();
            orderManager = new OrderManager();
            csvManager = new CSVManager();
        }

        // Обработчик нажатия кнопки "Добавить заказ"
        private void ButtonAddOrder_SIR_Click(object sender, EventArgs e)
        {
            // Создание формы для добавления нового заказа
            var addOrderForm = new FormAboutOrder_SIR();
            // Показ формы как диалогового окна и проверка результата
            if (addOrderForm.ShowDialog() == DialogResult.OK)
            {
                orderManager.AddOrder(addOrderForm.Order);
                UpdateDataGridView();
                UpdateChart();
            }
        }
        // Обработчик нажатия кнопки "Сохранить заказы"
        private void ButtonSaveOrder_SIR_Click(object sender, EventArgs e)
        {
            // Создание диалогового окна для сохранения файла
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Save CSV File"
            };
            // Показ диалогового окна и проверка результата
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    csvManager.SaveToCSV(orderManager.Orders, saveFileDialog.FileName);
                    MessageBox.Show("Данные успешно сохранены.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void UpdateDataGridView()
        {
            dataGridViewOrder_SIR.DataSource = null;
            dataGridViewOrder_SIR.DataSource = orderManager.Orders;
        }
        // Метод для обновления графика (диаграммы)
        private void UpdateChart()
        {
            // Очистка всех серий данных на графике
            chartOrder_SIR.Series.Clear();
            // Создание новой серии данных для графика
            var series = new Series
            {
                Name = "Сумма заказов",
                Color = System.Drawing.Color.Blue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            };
            // Добавление точек данных для каждого заказа
            foreach (var order in orderManager.Orders)
            {
                series.Points.AddXY(order.OrderNumber, order.Price);
            }
            // Добавление серии на график
            chartOrder_SIR.Series.Add(series);
            chartOrder_SIR.ChartAreas[0].AxisX.Title = "Номер заказа";
            chartOrder_SIR.ChartAreas[0].AxisY.Title = "Сумма";
        }
        // Обработчик нажатия кнопки "Поиск"
        private void ButtonSearch_SIR_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение поискового запроса из текстового поля с удалением пробелов
                var searchTerm = textBoxSearch_SIR.Text?.Trim(); 

                if (orderManager.Orders == null || orderManager.Orders.Count == 0)
                {
                    // Проверка наличия заказов для поиска
                    MessageBox.Show("Нет заказов для поиска.", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Выполнение поиска по имени клиента
                var filteredOrders = orderManager.SearchByClientName(searchTerm);
                // Проверка результатов поиска
                if (filteredOrders == null || filteredOrders.Count == 0)
                {
                    dataGridViewOrder_SIR.DataSource = null;

                    MessageBox.Show($"По запросу '{searchTerm}' ничего не найдено.",
                        "Результаты поиска",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    // Отображение найденных заказов в DataGridView
                    dataGridViewOrder_SIR.DataSource = filteredOrders;

                    MessageBox.Show($"Найдено заказов: {filteredOrders.Count}",
                        "Результаты поиска",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок при поиске
                MessageBox.Show($"Ошибка при поиске: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        // Обработчик нажатия кнопки "Сортировать по цене"
        private void buttonSortPrise_SIR_Click(object sender, EventArgs e)
        {
            // Проверка типа источника данных DataGridView
            if (dataGridViewOrder_SIR.DataSource is List<Order> currentOrders)
            {
                // Сортировка текущих отображаемых заказов по возрастанию цены
                var sortedOrders = currentOrders.OrderBy(o => o.Price).ToList();

                dataGridViewOrder_SIR.DataSource = null;
                dataGridViewOrder_SIR.DataSource = sortedOrders;

                Console.WriteLine("Заказы отсортированы по цене.");
            }
            else
            {
                orderManager.SortByPrice();
                UpdateDataGridView();
                Console.WriteLine("DataGridView обновлен.");
            }
        }
        // Обработчик нажатия кнопки "Фильтр по цене"
        private void buttonFilterPrice_SIR_Click(object sender, EventArgs e)
        {
            // Фильтрация по цене
            if (decimal.TryParse(textBoxMinPrice_SIR.Text, out decimal minPrice) &&
                decimal.TryParse(textBoxMaxPrice_SIR.Text, out decimal maxPrice))
            { 
                // Применение фильтра по цене
                var filteredOrders = orderManager.FilterByPrice(minPrice, maxPrice);
                dataGridViewOrder_SIR.DataSource = filteredOrders;
            }
            else
            {
                MessageBox.Show("Ошибка, пожалуйста, введите корректные значения цены.");
            }
        }
        // Обработчик нажатия кнопки "Статистика"
        private void buttonStatistic_SIR_Click(object sender, EventArgs e)
        {
            // Получение статистики по всем заказам
            var statistics = orderManager.GetStatistics();
            // Отображение статистики
            labelStatistick_SIR.Text = $"Общая сумма: {statistics.TotalCost}, Средняя сумма: {statistics.AverageCost}, Мин. сумма: {statistics.MinCost}, Макс. сумма: {statistics.MaxCost}";
        }
        // Обработчик нажатия кнопки "Загрузить из CSV"
        private void buttonLoadCSV_SIR_Click(object sender, EventArgs e)
        {
            // Создание диалогового окна для выбора файла
            var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Select a CSV File"
            };
            // Показ диалогового окна
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var orders = csvManager.LoadFromCSV(openFileDialog.FileName);
                    orderManager.Orders.Clear();
                    foreach (var order in orders)
                    {
                        orderManager.AddOrder(order);
                    }
                    UpdateDataGridView();
                    UpdateChart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // Обработчик нажатия кнопки "О программе" в ToolStrip
        private void toolStripButtonAboutProgramm_SIR_Click(object sender, EventArgs e)
        {
            FormAbout_SIR formAbout = new FormAbout_SIR();
            formAbout.ShowDialog();
        }
        // Обработчик нажатия кнопки "Руководство пользователя" в ToolStrip
        private void toolStripButtonUserGuide_SIR_Click(object sender, EventArgs e)
        {
            FormAboutMe_SIR formAbout = new FormAboutMe_SIR();
            formAbout.ShowDialog();
        }
        // Обработчик нажатия кнопки "Удалить заказ"
        private void buttonClose_SIR_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder_SIR.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ для удаления!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Запрос подтверждения удаления
            var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный заказ?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Получение выбранного заказа из DataGridView
                    var selectedOrder = (Order)dataGridViewOrder_SIR.SelectedRows[0].DataBoundItem;
                    orderManager.RemoveOrder(selectedOrder);

                    UpdateDataGridView();
                    UpdateChart();

                    MessageBox.Show("Заказ успешно удален!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении заказа: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Обработчик нажатия кнопки "Сбросить фильтр по цене"
        private void buttonRemovePrise_SIR_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateDataGridView();
                textBoxMinPrice_SIR.Clear();
                textBoxMaxPrice_SIR.Clear();

                MessageBox.Show("Фильтр по цене сброшен. Отображаются все заказы.",
                    "Сброс фильтра",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сбросе фильтра: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        // Обработчик нажатия кнопки "Сбросить поиск"
        private void buttonRemoveSearch_SIR_Click(object sender, EventArgs e)
        {
            textBoxSearch_SIR.Clear();
            UpdateDataGridView();
            textBoxSearch_SIR.Focus();
        }
       
    }

}
