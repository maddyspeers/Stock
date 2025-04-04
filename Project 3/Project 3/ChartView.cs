using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_3
{
    public partial class ChartView : Form
    {
        List<CandleStick> candlesticks = new List<CandleStick>();
      
   
        /// add colors for up and down prices, adding values to the stock chart
        public ChartView()
        {
            InitializeComponent();
            InitializeRecognizer();

            viewchart.Series["OHLC"].XValueMember = "Date";
            viewchart.Series["OHLC"].YValuesPerPoint = 4;
            viewchart.Series["OHLC"].YValueMembers = "High,Low,Open,Close";

            viewchart.ChartAreas["OHLC"].AxisX.MajorGrid.LineWidth = 0;
            viewchart.ChartAreas["OHLC"].AxisY.MajorGrid.LineWidth = 0;

            viewchart.Series["OHLC"].CustomProperties = "PriceUpColor=Green, PriceDownColor=Red";
        }
        /// updates max and min values for chart
        private void updateviewchart()
        {
            var dataSource = viewchart.DataSource as List<CandleStick>;

            if (dataSource != null)
            {
                candlesticks = dataSource;
                double maxY = candlesticks.Max(cs => cs.High);
                double minY = candlesticks.Min(cs => cs.Low);
                double padding = 0.10 * (maxY - minY);

                viewchart.ChartAreas["OHLC"].AxisY.Maximum = maxY + padding;
                viewchart.ChartAreas["OHLC"].AxisY.Minimum = minY - padding;
            }
        }
        /// Create recognizer for all doji patterns
        List<Recognizer> recognizers = new List<Recognizer>(32);
        private List<Recognizer> InitializeRecognizer()
        {
            Recognizer recognizer = null;

            recognizer = new Recognizer_Bullish();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_Bearish();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_Neutral();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_NeutralDoji();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_Doji();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_DragonFly();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_GravestoneDoji();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_Hammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BullishHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_BearishHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_invertedHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_bullishInvertedHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_bearishInvertedHammer();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_Marubozu();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_bMarubozu();
            recognizers.Add(recognizer);

            recognizer = new Recognizer_wMarubozu();
            recognizers.Add(recognizer);

            comboDoji.Items.Clear();

            foreach (Recognizer re in recognizers)
            {
                comboDoji.Items.Add(re.patternName);
            }

            comboDoji.Enabled = true;

            return recognizers;
        }
        /// load the chart
        private void Chart_View_Load(object sender, EventArgs e)
        {

        }
        /// change the combo box index for annotations on the chart
        private void comboDoji_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateviewchart();

            Recognizer re = recognizers[comboDoji.SelectedIndex];
            List<int> retcon = re.recognize(candlesticks);
            viewchart.Annotations.Clear();
            foreach (int i in retcon)
            {
                RectangleAnnotation annotate = new RectangleAnnotation();
                annotate.Text = re.patternName;
                annotate.AnchorDataPoint = viewchart.Series["OHLC"].Points[i];
                viewchart.Annotations.Add(annotate);
            }
        }
    }
}
