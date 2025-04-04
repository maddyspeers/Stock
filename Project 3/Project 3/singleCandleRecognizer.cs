using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
   
    /// recognizer bullish
    
    internal class Recognizer_Bullish : Recognizer
    {
        public Recognizer_Bullish() : base("Bullish", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isBullish;
        }
    }
    
    /// recognizer bearish
    
    internal class Recognizer_Bearish : Recognizer
    {
        public Recognizer_Bearish() : base("Bearish", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isBearish;
        }
    }
    
    /// recognizer neutral
   

    internal class Recognizer_Neutral : Recognizer 
    {
        public Recognizer_Neutral() : base("Neutral", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isNeutral;
        }
    }
    
    /// recognizer doji
   

    internal class Recognizer_Doji : Recognizer
    {
        public Recognizer_Doji() : base("Doji", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isDoji;
        }
    }
    /// recognizer dragonfly
    internal class Recognizer_DragonFly : Recognizer
    {
        public Recognizer_DragonFly() : base("Dragonfly", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isDragonFlyDoji;
        }
    }
    /// recognizer neutral doji

    internal class Recognizer_NeutralDoji : Recognizer
    {
        public Recognizer_NeutralDoji() : base("Neutral Doji", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isNeutralDoji;
        }
    }
    /// recognizer gravestone doji

    internal class Recognizer_GravestoneDoji : Recognizer
    {
        public Recognizer_GravestoneDoji() : base("Gravestone Doji", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isGravestoneDoji;
        }
    }
    /// recogznier long legged doji
    internal class Recognizer_LongLeggedDoji : Recognizer
    {
        public Recognizer_LongLeggedDoji() : base("LongLegged Doji", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isLongLeggedDoji;
        }
    }
    /// recognizer hammer
    internal class Recognizer_Hammer : Recognizer
    {
        public Recognizer_Hammer() : base("Hammer", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isHammer;
        }
    }
    /// recognizer bullish hammer

    internal class Recognizer_BullishHammer : Recognizer
    {
        public Recognizer_BullishHammer() : base("Bullish Hammer", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isBullishHammer;
        }
    }
    /// recognizer bearish hammer

    internal class Recognizer_BearishHammer : Recognizer
    {
        public Recognizer_BearishHammer() : base("Bearish Hammer", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isBearishHammer;
        }
    }
    /// recognizer inverted hammer

    internal class Recognizer_invertedHammer : Recognizer
    {
        public Recognizer_invertedHammer() : base("Inverted Hammer", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isInvertedHammer;
        }
    }
    /// recognizer bullish inverted hammer

    internal class Recognizer_bullishInvertedHammer : Recognizer
    {
        public Recognizer_bullishInvertedHammer() : base("Bullish Inverted Hammer", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isBullishInvertedHammer;
        }
    }

    /// recognizer bearish inverted hammer 
    internal class Recognizer_bearishInvertedHammer : Recognizer
    {
        public Recognizer_bearishInvertedHammer() : base("Bearish Inverted Hammer", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isBearishInvertedHammer;
        }
    }
    /// recognizer marubozu
    internal class Recognizer_Marubozu : Recognizer
    {
        public Recognizer_Marubozu() : base("Marubozu", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isMarubozu;
        }
    }
    /// recognizer white marubozu
    internal class Recognizer_wMarubozu : Recognizer
    {
        public Recognizer_wMarubozu() : base("White Marubozu", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isWhiteMarubozu;
        }
    }
    /// recognizer black marubozu
    internal class Recognizer_bMarubozu : Recognizer
    {
        public Recognizer_bMarubozu() : base("Black Marubozu", 1) { }
        protected override bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks)
        {
            return subsetOfCandleSticks[0].isBlackMarubozu;
        }
    }
}
