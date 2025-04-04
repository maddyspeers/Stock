using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{    /// recognizing engulfing bullish
    internal class EngulfingBullishCandlestick_Recognizer : Recognizer
    {
        public EngulfingBullishCandlestick_Recognizer() : base("Bullish Engulfing Pattern", 2) { }

        protected override bool patternMatchesSubset(List<CandleStick> Lcs)
        {
            CandleStick pcs = Lcs[0];
            CandleStick cs = Lcs[1];
            return pcs.isBearish && cs.isBullish && pcs.High < cs.topPrice && pcs.Low < cs.bottomPrice;
        }
    }
    /// recognizing engulfing bearish
    internal class EngulfingBearishCandlestick_Recognizer : Recognizer
    {
        public EngulfingBearishCandlestick_Recognizer() : base("Bearish Engulfing Pattern", 2) { }

        protected override bool patternMatchesSubset(List<CandleStick> Lcs)
        {
            CandleStick pcs = Lcs[0];
            CandleStick cs = Lcs[1];
            return pcs.isBullish && cs.isBearish && pcs.High < cs.topPrice && pcs.Low < cs.bottomPrice;
        }
    }
}
