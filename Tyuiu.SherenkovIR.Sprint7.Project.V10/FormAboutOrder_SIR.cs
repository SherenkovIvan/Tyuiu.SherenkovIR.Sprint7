using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SherenkovIR.Sprint7.Project.V10.Lib;

namespace Tyuiu.SherenkovIR.Sprint7.Project.V10
{
    public partial class FormAboutOrder_SIR : Form
    {
        public Order Order { get; private set; }
        public FormAboutOrder_SIR()
        {
            InitializeComponent();
        }

        private void ButtonSaveOrder_SIR_Click(object sender, EventArgs e)
        {
            Order = new Order
            {
                OrderNumber = textBoxOrderNumber_SIR.Text,
                FirstName = textBoxFirstName_SIR.Text,
                LastName = textBoxLastName_SIR.Text,
                MiddleName = textBoxMiddleName_SIR.Text,
                Index = textBoxIndex_SIR.Text,
                City = textBoxCity_SIR.Text,
                Address = textBoxAddress_SIR.Text,
                PhoneNumber = textBoxNumberPhone_SIR.Text,
                OrderDate = dateTimePickerOrderDate_SIR.Value,
                OrderName = textBoxOrderName_SIR.Text,
                Price = decimal.Parse(textBoxPrise_SIR.Text),
                Quantity = int.Parse(textBoxQuanity_SIR.Text),
                AccountNumber = textBoxAccountNumber_SIR.Text
            };
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void buttonCancel_SIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
