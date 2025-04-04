using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    internal class candlestickReader
    {
        const string dataFolder = "Stock Data";

        public List<CandleStick> listOfCandlesticks = null;

        public candlestickReader()
        {
            listOfCandlesticks = new List<CandleStick>(256);
        }

        /// Read candlestick list
        public List<CandleStick> ReadlistOfCandlesticks(string csvFileName, DateTime startDate, DateTime endDate)
        {
            char[] seperators = new char[] { '-', ',', '"' };

            /// Read all lines
            String[] lines = System.IO.File.ReadAllLines(csvFileName);

            /// Skip the header
            String header = lines[0];

            /// file is in the candlestick file
            if (header == "\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Volume\"")
            {
                /// Create list of candlesticks
                listOfCandlesticks = new List<CandleStick>(lines.Length - 1);

                for (int l = 1; l < lines.Length; l++)
                {
                    /// Get nth line
                    String line = lines[l].Trim();

                    /// Split the lines
                    string[] subStrings = line.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

                    /// Convert the substrings into intergers
                    int year = int.Parse(subStrings[0]);
                    int month = int.Parse(subStrings[1]);
                    int day = int.Parse(subStrings[2]);

                    /// Compile the date
                    DateTime date = new DateTime(year, month, day);

                    /// Check if the dates are within datetimepickers
                    if (date.CompareTo(startDate) >= 0 && date.CompareTo(endDate) < 0)
                    {
                        /// Convert the substrings into decimals (and long)
                        double open = double.Parse(subStrings[3]);
                        double high = double.Parse(subStrings[4]);
                        double low = double.Parse(subStrings[5]);
                        double close = double.Parse(subStrings[6]);
                        long volume = long.Parse(subStrings[7]);

                        /// Round the decimals to 2 places
                        open = Math.Round(open, 2);
                        high = Math.Round(high, 2);
                        low = Math.Round(low, 2);
                        close = Math.Round(close, 2);

                        /// Compile the values into single candlestick
                        CandleStick candlestick = new CandleStick(date, open, high, low, close, volume);

                        /// Add a candlestick to list
                        listOfCandlesticks.Add(candlestick);
                    }
                }
            }

            return listOfCandlesticks;
        }

        internal List<CandleStick> readStock(string ticker, DateTime startDate, DateTime endDate)
        {
            /// Get .csv file name    

            String csvFileName = dataFolder + @"\" + ticker;

            listOfCandlesticks = ReadlistOfCandlesticks(csvFileName, startDate, endDate);

            return listOfCandlesticks;
        }
    }
}
