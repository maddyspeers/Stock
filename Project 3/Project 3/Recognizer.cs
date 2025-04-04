using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    /// recognizing doji patterns
    internal abstract class Recognizer
    {
        /// pattern name
        public string patternName { get; set; }
        /// pattern size
        public int patternSize { get; set; }
        /// if pattern matches subset, add and return the result of the doji
        protected abstract bool patternMatchesSubset(List<CandleStick> subsetOfCandleSticks);

        public List<int> recognize(List<CandleStick> candleSticks)
        {
            List<int> result = new List<int>(candleSticks.Count / 8);

            int offset = patternSize - 1;

            for (int i = offset; i < candleSticks.Count; i++)
            {
                List<CandleStick> subset = candleSticks.GetRange(i - offset, patternSize);

                if (patternMatchesSubset(subset))
                {
                    result.Add(i);
                }
            }

            return result;
        }
        /// recognize doji pattern based on name and size
        public Recognizer(string pName, int pSize) => (patternName, patternSize) = (pName, pSize);
    }
}
