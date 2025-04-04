using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    internal class CandleStick
    {
        /// Sets default values, as well as gets the set values
        
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public long Volume { get; set; }

        /// determine candlestick properties
        
        public double range { get; private set; }
        public double body { get; private set; }
        public double upperTail { get; private set; }
        public double lowerTail { get; private set; }
        public double topPrice { get; private set; }
        public double bottomPrice { get; private set; }

        /// bullish/bearish/neutral 
        
        public Boolean isBullish { get; private set; }
        public Boolean isNeutral { get; private set; }
        public Boolean isBearish { get; private set; }

        /// Doji variations 
        
        public Boolean isDoji { get; private set; }
        public Boolean isGravestoneDoji { get; private set; }
        public Boolean isNeutralDoji { get; private set; }
        public Boolean isDragonFlyDoji { get; private set; }
        public Boolean isLongLeggedDoji { get; private set; }

        /// Hammer!!!!!
        public Boolean isHammer { get; private set; }
        public Boolean isBullishHammer { get; private set; }
        public Boolean isBearishHammer { get; private set; }

        /// Inverted hammer variations :)
        
        public Boolean isInvertedHammer { get; private set; }
        public Boolean isBullishInvertedHammer { get; private set; }
        public Boolean isBearishInvertedHammer { get; private set; }

        
        /// Marubozu slay
        public Boolean isMarubozu { get; private set; }
        public Boolean isWhiteMarubozu { get; private set; }
        public Boolean isBlackMarubozu { get; private set; }

        /// Pattern testing slay

        public Boolean dojiTest(double candlestickbody = 0.03)
        {
            return body <= candlestickbody * range;
        }
        public Boolean neutralDojiTest(double candlestickbody = 0.03)
        {
            return dojiTest(candlestickbody);
        }

        public Boolean dragonflyDojiTest(double candlestickbody = 0.03, double upperTailTolerance = 0.05)
        {
            return dojiTest(candlestickbody) && (upperTail <= range * upperTailTolerance);
        }

        public Boolean gravestoneDojiTest(double candlestickbody = 0.03, double lowerTailTolerance = 0.05)
        {
            return dojiTest(candlestickbody) && (upperTail <= range * lowerTailTolerance);
        }

        public Boolean longleggedDojiTest(double candlestickbody = 0.03, double positionToleranceAroundCenter = 0.10)
        {
            double longestTail = Math.Max(upperTail, lowerTail);
            return dojiTest(candlestickbody) && (longestTail <= range * (0.5 - positionToleranceAroundCenter));
        }

        public Boolean hammerTest(double mincandlestickbody = 0.15, double maxcandlestickbody = 0.25, double upperTailTolerance = .10)
        {
            return (mincandlestickbody * range <= body) && (body >= maxcandlestickbody * range) && (upperTail <= upperTailTolerance);
        }

        public Boolean bullishHammerTest(double mincandlestickbody = 0.15, double maxcandlestickbody = 0.25, double upperTailTolerance = .10)
        {
            return hammerTest(mincandlestickbody, maxcandlestickbody, upperTailTolerance) && (Close > Open);
        }

        public Boolean bearishHammerTest(double mincandlestickbody = 0.15, double maxcandlestickbody = 0.25, double upperTailTolerance = .10)
        {
            return hammerTest(mincandlestickbody, maxcandlestickbody, upperTailTolerance) && (Close < Open);
        }

        public Boolean invertedHammerTest(double mincandlestickbody = 0.15, double maxcandlestickbody = 0.25, double lowerTailTolerance = .10)
        {
            return hammerTest(mincandlestickbody, maxcandlestickbody, lowerTailTolerance) && (Close < Open);
        }

        public Boolean bullishInvertedHammerTest(double candlestickbody = 0.03)
        {
            return invertedHammerTest(candlestickbody) && isBullish == true;
        }

        public Boolean bearishInvertedHammerTest(double candlestickbody = 0.03)
        {
            return invertedHammerTest(candlestickbody) && isBearish == true;
        }

        public Boolean marubozuTest(double candlestickbody = 0.03)
        {
            return body > range * (1 - candlestickbody);
        }

        public Boolean wMarubozuTest(double candlestickbody = 0.03)
        {
            return marubozuTest(candlestickbody) && isBullish == true;
        }

        public Boolean bMarubozuTest(double candlestickbody = 0.03)
        {
            return marubozuTest(candlestickbody) && isBearish == true;
        }

        public CandleStick()
        {
            /// Sets default values for Date, Open, Close, High, Low, & Volume

            Date = DateTime.Now;
            Open = 0;
            Close = 0;
            High = 0;
            Low = 0;
            Volume = 0;
        }

        public CandleStick(DateTime date, double open, double high, double low, double close, long volume)
        {
            Date = date;
            Open = open;
            Close = close;
            High = high;
            Low = low;
            Volume = volume;

            computeProperties();
        }

        /// Compute properties

        private void computeProperties()
        {
            range = High - Low;
            body = Math.Max(Open, Close) - Math.Min(Open, Close);
            topPrice = High - Math.Max(Open, Close);
            bottomPrice = Math.Min(Open, Close) - Low;
            upperTail = High - topPrice;
            lowerTail = bottomPrice - Low;

            computePatterns();
        }


        /// Compute the doji patterns

        private void computePatterns()
        {
            /// General

            isBullish = Close > Open;
            isNeutral = Close == Open;
            isBearish = Close < Open;

            /// Doji

            isDoji = dojiTest();
            isDragonFlyDoji = dragonflyDojiTest();
            isGravestoneDoji = gravestoneDojiTest();
            isNeutralDoji = Close == Open;
            isLongLeggedDoji = longleggedDojiTest();

            /// Hammer

            isHammer = hammerTest();
            isBullishHammer = bullishHammerTest();
            isBearishHammer = bearishHammerTest();

            /// Inverted Hammers

            isInvertedHammer = invertedHammerTest();
            isBullishInvertedHammer = bullishHammerTest();
            isBearishInvertedHammer = bearishHammerTest();

            /// Marobozu 

            isMarubozu = marubozuTest();
            isWhiteMarubozu = wMarubozuTest();
            isBlackMarubozu = bMarubozuTest();
        }
    }
}
