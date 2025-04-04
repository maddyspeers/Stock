using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class CandlestickForm : Form
    {
        candlestickReader CandleStick = null;
        List<CandleStick> candlestickList = null;

        FileInfo[] Files = null;
        public static CandlestickForm instance;

        /// get csv files
        public CandlestickForm()
        {
            InitializeComponent();

            CandleStick = new candlestickReader();
            instance = this;
            string fileName = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            string filePath = fileName + "/Stock Data/";
            DirectoryInfo dl = new DirectoryInfo(filePath);
            Files = dl.GetFiles("*.csv");
        }
        /// load form
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// add doji pattern to the selected radio buttom from the csv file based on day,week or month
        private void buttonDay_CheckedChanged(object sender, EventArgs e)
        {
            string date = String.Empty;
            date = "Day";
            stockcombo.Items.Clear();

            foreach(FileInfo file in Files)
            {
                if ((file.Name).Contains(date))
                {
                    stockcombo.Items.Add(file.Name);
                }
            }

            Controls.Add(stockcombo);
        }

        private void buttonMonth_CheckedChanged(object sender, EventArgs e)
        {
            string date = String.Empty;
            date = "Month";
            stockcombo.Items.Clear();

            foreach (FileInfo file in Files)
            {
                if ((file.Name).Contains(date))
                {
                    stockcombo.Items.Add(file.Name);
                }
            }
        }

        private void buttonWeek_CheckedChanged(object sender, EventArgs e)
        {
            string date = String.Empty;
            date = "Week";
            stockcombo.Items.Clear();

            foreach (FileInfo file in Files)
            {
                if ((file.Name).Contains(date))
                {
                    stockcombo.Items.Add(file.Name);
                }
            }
        }
        /// load the form, based on if the day week or month radio button was clicked, read stock
        private void loadbutton_Click(object sender, EventArgs e)
        {
            string period = String.Empty;

            if (buttonDay.Checked)
            {
                period = "Day";
            }
            else if (buttonMonth.Checked)
            {
                period = "Month";
            }
            else if (buttonWeek.Checked)
            {
                period = "Week";
            }
            else
            {
                period = "Day";
            }
            ChartView chart = new ChartView();
            candlestickList = CandleStick.readStock(stockcombo.Text, dateTimePicker1.Value, dateTimePicker2.Value);
            chart.viewchart.DataSource = candlestickList;

            chart.Show();

                
        }
    }
}
