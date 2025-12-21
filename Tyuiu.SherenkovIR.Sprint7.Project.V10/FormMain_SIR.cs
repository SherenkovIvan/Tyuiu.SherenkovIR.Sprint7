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

        private void ButtonAddOrder_SIR_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSaveOrder_SIR_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_SIR_Click(object sender, EventArgs e)
        {

        }

        private void buttonSortByDate_SIR_Click(object sender, EventArgs e)
        {

        }

        private void buttonSortPrise_SIR_Click(object sender, EventArgs e)
        {

        }

        private void buttonFilterPrice_SIR_Click(object sender, EventArgs e)
        {

        }

        private void buttonStatistic_SIR_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadCSV_SIR_Click(object sender, EventArgs e)
        {

        }
    }

}
