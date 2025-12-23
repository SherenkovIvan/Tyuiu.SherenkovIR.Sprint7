using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.SherenkovIR.Sprint7.Project.V10.Lib;
namespace Tyuiu.SherenkovIR.Sprint7.Project.V10
{
    public partial class FormMain_SIR : Form
    {
        private OrderManager orderManager;
        private CSVManager csvManager;
        public FormMain_SIR()
        {
            InitializeComponent();
            orderManager = new OrderManager();
            csvManager = new CSVManager();
        }

        private void FormMain_SIR_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonAddOrder_SIR_Click(object sender, EventArgs e)
        {
            var addOrderForm = new FormAboutOrder_SIR();
            if (addOrderForm.ShowDialog() == DialogResult.OK)
            {
                orderManager.AddOrder(addOrderForm.Order);
                UpdateDataGridView();
                UpdateChart();
            }
        }

        private void ButtonSaveOrder_SIR_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Save CSV File"
            };

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
        private void UpdateChart()
        {
            chartOrder_SIR.Series.Clear();
            var series = new Series
            {
                Name = "Сумма заказов",
                Color = System.Drawing.Color.Blue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            };

            foreach (var order in orderManager.Orders)
            {
                series.Points.AddXY(order.OrderNumber, order.Price);
            }

            chartOrder_SIR.Series.Add(series);
            chartOrder_SIR.ChartAreas[0].AxisX.Title = "Номер заказа";
            chartOrder_SIR.ChartAreas[0].AxisY.Title = "Сумма";
        }

        private void ButtonSearch_SIR_Click(object sender, EventArgs e)
        {
            var searchTerm = textBoxSearch_SIR.Text;
            var filteredOrders = orderManager.SearchByClientName(searchTerm);
            dataGridViewOrder_SIR.DataSource = filteredOrders;
        }

        private void buttonSortByDate_SIR_Click(object sender, EventArgs e)
        {
            orderManager.SortByOrderDate();
            UpdateDataGridView();
        }

        private void buttonSortPrise_SIR_Click(object sender, EventArgs e)
        {
            orderManager.SortByPrice();
            Console.WriteLine("Заказы отсортированы по цене.");
            UpdateDataGridView();
            Console.WriteLine("DataGridView обновлен.");
        }

        private void buttonFilterPrice_SIR_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxMinPrice_SIR.Text, out decimal minPrice) &&
                decimal.TryParse(textBoxMaxPrice_SIR.Text, out decimal maxPrice))
            {
                var filteredOrders = orderManager.FilterByPrice(minPrice, maxPrice);
                dataGridViewOrder_SIR.DataSource = filteredOrders;
            }
            else
            {
                MessageBox.Show("Ошибка, пожалуйста, введите корректные значения цены.");
            }
        }

        private void buttonStatistic_SIR_Click(object sender, EventArgs e)
        {
            var statistics = orderManager.GetStatistics();
            labelStatistick_SIR.Text = $"Общая сумма: {statistics.TotalCost}, Средняя сумма: {statistics.AverageCost}, Мин. сумма: {statistics.MinCost}, Макс. сумма: {statistics.MaxCost}";
        }

        private void buttonLoadCSV_SIR_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Select a CSV File"
            };

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

        private void toolStripButtonAboutProgramm_SIR_Click(object sender, EventArgs e)
        {
            FormAbout_SIR formAbout = new FormAbout_SIR();
            formAbout.ShowDialog();
        }

        private void toolStripButtonUserGuide_SIR_Click(object sender, EventArgs e)
        {
            FormAboutMe_SIR formAbout = new FormAboutMe_SIR();
            formAbout.ShowDialog();
        }

       
    }

}
