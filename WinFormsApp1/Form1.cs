using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExchangeLibrary;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var services = new ExchangeService(new ApiCalls());

            var currencies = services.ReturnAllCodes().supported_codes;


            var currDict = services.GetCodesInList(currencies);
            InitializeComponent();

            

            dataGridView1.DataSource = currDict;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
