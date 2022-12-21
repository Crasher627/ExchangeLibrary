using ExchangeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserGui
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var services = new ExchangeService(new ApiCalls());

            var currencies = services.ReturnAllCodes().supported_codes;

            var currDict = services.GetCodesInList(currencies);


            ComboBox comboBox = new ComboBox();

            comboBox.Location = new Point(40, 40);
            comboBox.Size = new Size(220, 30);
            

            comboBox.DataSource = new BindingSource(currDict, null);
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";

            this.Controls.Add(comboBox);

            currenciesComboBox.Items.Add("Test");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void currenciesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
