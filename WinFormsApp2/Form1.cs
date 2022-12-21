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

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        readonly ExchangeService _service = new ExchangeService(new ApiCalls());

        Dictionary<string, string> currencyAndKey;
        List<string> histCurr = new List<string>()
        {
            "AUD",
            "DKK",
            "IEP",
            "MYR",
            "TWD",
            "ATS",
            "ESP",
            "INR",
            "NOK",
            "USD",
            "BEF",
            "EUR",
            "IRR",
            "NLG",
            "ZAR",
            "BRL",
            "FIM",
            "ITL",
            "NZD",
            "CAD",
            "FRF",
            "JPY",
            "PTE",
            "CHF",
            "GBP",
            "KRW",
            "SEK",
            "CNY",
            "GRD",
            "LKR",
            "SGD",
            "DEM",
            "HKD",
            "MXN",
            "THB"

        };
        public Form1()
        {
            InitializeComponent();

            numToConvert.Maximum = Decimal.MaxValue;
            latestAmount.Maximum = Decimal.MaxValue;
            histAmount.Maximum = Decimal.MaxValue;

            BindingSource bs4 = new BindingSource();
            bs4.DataSource = histCurr;
            comboBoxHistorical.DataSource = bs4;


            Task.Run(() =>
            {


                currencyAndKey = _service.GetCodesInDict();

                BindingSource bs1 = new BindingSource();
                BindingSource bs2 = new BindingSource();
                BindingSource bs3 = new BindingSource();
                

                bs1.DataSource = currencyAndKey;
                bs2.DataSource = currencyAndKey;
                bs3.DataSource = currencyAndKey;
                

                //bs.Add(keys);

                comboBoxCurrencies.Invoke(new Action(() => {
                    comboBoxCurrencies.DataSource = bs1;
                    comboBoxCurrencies.DisplayMember = "Value";
                    comboBoxCurrencies.ValueMember = "Key";
                    comboBoxCurrencies.Enabled = true;
                }));

                comboBoxBaseCurr.Invoke(new Action(() => {
                    comboBoxBaseCurr.DataSource = bs2;
                    comboBoxBaseCurr.DisplayMember = "Value";
                    comboBoxBaseCurr.ValueMember = "Key";
                    comboBoxBaseCurr.Enabled = true;
                }));

                comboBoxTargetCurr.Invoke(new Action(() => {
                    comboBoxTargetCurr.DataSource = bs3;
                    comboBoxTargetCurr.DisplayMember = "Value";
                    comboBoxTargetCurr.ValueMember = "Key";
                    comboBoxTargetCurr.Enabled = true;
                }));

            });
        }


      

        /*private void availableCurrencies_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                

                currencyAndKey = _service.GetCodesInDict();

                BindingSource bs = new BindingSource();

                bs.DataSource = currencyAndKey;

                //bs.Add(keys);

                comboBoxCurrencies.Invoke(new Action(() => { comboBoxCurrencies.DataSource = bs;
                    comboBoxCurrencies.DisplayMember = "Value";
                    comboBoxCurrencies.ValueMember = "Key";
                    comboBoxCurrencies.Enabled = true;
                }));
            });
        }*/

        private void buttonToGetLatestRates_Click_1(object sender, EventArgs e)
        {

            var currencyKey = (string)comboBoxCurrencies.SelectedValue;
            if (currencyKey != null)
            {
                Task.Run(() =>
                {


                    var results = _service.ReturnLatestRates(currencyKey);

                    var rates = _service.GetLatestRatesInDict(results.conversion_rates);

                    BindingSource bs = new BindingSource();

                    bs.DataSource = rates;

                    //bs.Add(keys);

                    dataGridView1.Invoke(new Action(() =>
                    {
                        dataGridView1.DataSource = bs;
                        dataGridView1.AutoGenerateColumns = false;
                    }));

                    lastUpdated.Invoke(new Action(() =>
                    {
                        lastUpdated.Text = results.time_last_update_utc;
                    }));

                    nextUpdate.Invoke(new Action(() =>
                    {
                        nextUpdate.Text = results.time_next_update_utc;
                    }));

                    baseCodeTxt.Invoke(new Action(() =>
                    {
                        baseCodeTxt.Text = results.base_code;
                    }));


                });
            }
        }


        private void pairConvertBtn_Click(object sender, EventArgs e)
        {
            var baseCurr = (string)comboBoxBaseCurr.SelectedValue;
            var targetCurr = (string)comboBoxTargetCurr.SelectedValue;
            if (baseCurr != null && targetCurr != null)
            {
                Task.Run(() =>
                {
                    var pairRate = _service.ReturnPairRates(baseCurr, targetCurr);

                    timeLastUpd.Invoke(new Action(() => { timeLastUpd.Text = pairRate.time_last_update_utc; }));

                    timeNextUpd.Invoke(new Action(() => { timeNextUpd.Text = pairRate.time_next_update_utc; }));

                    baseCurrTxt.Invoke(new Action(() => { baseCurrTxt.Text = pairRate.base_code; }));

                    targetCurrTxt.Invoke(new Action(() => { targetCurrTxt.Text = pairRate.target_code; }));

                    convRate.Invoke(new Action(() => { convRate.Text = pairRate.conversion_rate.ToString(); }));

                    if (numToConvert.Value != 0)
                    {
                        var newAmount = _service.ConvertAmount(decimal.ToDouble(numToConvert.Value),
                            pairRate.conversion_rate);
                        convertedAmount.Invoke(new Action(() =>
                        {
                            convertedAmount.Text = newAmount.ToString();
                        }));

                    }
                });
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = (double)dataGridView1[e.ColumnIndex, e.RowIndex].Value;
            var amount = decimal.ToDouble(latestAmount.Value);
            if (amount > 0 && cellValue > 0)
            {
                var converted = _service.ConvertAmount(amount, cellValue);
                MessageBox.Show(converted.ToString());
            }
            
        }

        private void buttonHistorical_Click(object sender, EventArgs e)
        {
            var year = dateTimePicker1.Value.Year;
            var month = dateTimePicker1.Value.Month;
            var day = dateTimePicker1.Value.Day;
            var currency = comboBoxHistorical.SelectedValue.ToString();

            if (currency != null)
            {
                Task.Run(() =>
                {
                    var histResults = _service.ReturnHistoricalRates(currency, year, month, day);

                    var histRates = _service.GetHistoricalRatesInDict(histResults.conversion_rates);

                    BindingSource bs = new BindingSource();

                    bs.DataSource = histRates;

                    //bs.Add(keys);

                    dataGridView2.Invoke(new Action(() =>
                    {
                        dataGridView2.DataSource = bs;
                        dataGridView2.AutoGenerateColumns = false;
                    }));

                    selectedDate.Invoke(new Action(() =>
                    {
                        selectedDate.Text = $"{histResults.year}/{histResults.month}/{histResults.day}";
                    }));

                    baseHistCurr.Invoke(new Action(() =>
                    {
                        baseHistCurr.Text = histResults.base_code;
                    }));



                });
            }

            //MessageBox.Show($"{dateTimePicker1.Value.Day} {dateTimePicker1.Value.Month} {dateTimePicker1.Value.Year} {comboBoxHistorical.SelectedValue}");
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var cellValue = (double)dataGridView2[e.ColumnIndex, e.RowIndex].Value;
            var amount = decimal.ToDouble(histAmount.Value);
            if (amount > 0 && cellValue > 0)
            {
                var converted = _service.ConvertAmount(amount, cellValue);
                MessageBox.Show(converted.ToString());
            }
            
        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
