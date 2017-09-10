using System.Collections.Generic;
using System.Linq;

namespace Crypto
{
    class Cyphers
    {
        public Cyphers()
        {
            intervals = new List<Interval>();
            intervals.Add(new Interval('A', 'Z'));
            intervals.Add(new Interval('a', 'z'));
            for (int i = 0; i < intervals.Count; i++)
            {
                generallength += intervals[i].Length;
            }
        }
        private int generallength;
        public int GeneralLength
        {
            get { return generallength; }
            set { }
        }
        private List<Interval> intervals;
        public List<Interval> Intervals
        {
            get
            {
                return intervals;
            }
            set
            {
                
            }
        }

        public string EncryptCaesar(string text, string key)
        {
            string result = "";
            int[] InputCode = GetInputCode(text);
            char[] keychars = key.ToCharArray();
            int truekey = 0;
            try
            {
                truekey = int.Parse(key);
            }
            catch
            {
                foreach (var figure in keychars)
                {
                    truekey += figure;
                }
            }

            int[] EncryptedInput = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                if (InputCode[i] >= 0)
                {
                    EncryptedInput[i] = InputCode[i] + truekey;
                    if (EncryptedInput[i] >= GeneralLength)
                    {
                        EncryptedInput[i] %= GeneralLength;
                    }
                }
                else
                {
                    EncryptedInput[i] = InputCode[i];
                }
                
            }

            char[] charsresult = GetOutputCode(EncryptedInput);
            foreach (var sign in charsresult)
            {
                result += sign;
            }

            return result;
        }

        public int[] Test(string text)
        {
            int[] array = GetInputCode(text);
            return array;
        }

        public string DecryptCaesar(string text, string key)
        {
            string result = "";
            int[] InputCode = GetInputCode(text);
            char[] keychars = key.ToCharArray();
            int truekey = 0;
            try
            {
                truekey = int.Parse(key);
            }
            catch
            {
                foreach (var figure in keychars)
                {
                    truekey += figure;
                }
            }

            int[] DecryptedInput = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                if (InputCode[i] < 0)
                {
                    DecryptedInput[i] = InputCode[i];
                }
                else
                {
                    DecryptedInput[i] = InputCode[i] - truekey;
                    while (DecryptedInput[i] < 0)
                    {
                        DecryptedInput[i] += GeneralLength;
                    }
                }
                
            }

            char[] charsresult = GetOutputCode(DecryptedInput);
            foreach (var sign in charsresult)
            {
                result += sign;
            }

            return result;
        }

        public int[] GetInputCode(string text)
        {
            int diff = 0;
            int[] InputCode = new int[text.Length];
            char[] chars = text.ToCharArray();
            int[] betweenintervals = new int[intervals.Count];
            betweenintervals[0] = 0;
            for (int i = 1; i < intervals.Count; i++)
            {
                betweenintervals[i] = intervals[i].Start - intervals[i - 1].End - 1;
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (IsInInterval(chars[i]))
                {
                    for (int j = 0; j < intervals.Count; j++)
                    {
                        if (intervals[j].End >= chars[i] && intervals[j].Start <= chars[i])
                        {
                            for (int k = 0; k <= j; k++)
                            {
                                diff += betweenintervals[k]; 
                            }
                            InputCode[i] = chars[i] - intervals[0].Start - diff;
                            diff = 0;
                        }
                    }
                }
                else
                {
                    InputCode[i] = chars[i] * (-1);
                }

            }

            return InputCode;
        }

        public char[] GetOutputCode(int[] array)
        {
            int diff = 0;
            int measure = 0;
            char[] chars = new char[array.Length];
            int[] betweenintervals = new int[intervals.Count];
            betweenintervals[0] = 0;
            for (int i = 1; i < intervals.Count; i++)
            {
                betweenintervals[i] = intervals[i].Start - intervals[i - 1].End - 1;
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    chars[i] = (char)(array[i] * (-1));
                }
                else
                {
                    for (int j = 0; j < intervals.Count; j++)
                    {
                        measure += intervals[j].Length;
                        diff += betweenintervals[j];
                        if (array[i] < measure)
                        {
                            chars[i] = (char)(array[i] + intervals[0].Start + diff);
                            measure = 0;
                            diff = 0;
                            break;
                        }
                    }
                }
            }

            return chars;
        }

        protected bool IsInInterval(char element)
        {
            for (int i = 0; i < intervals.Count; i++)
            {
                if (element >= intervals[i].Start && element <= intervals[i].End)
                {
                    return true;
                }
            }

            return false;
        }

        public struct Interval
        {
            public int Start;
            public int End;

            public Interval(char start, char end)
            {
                Start = start;
                End = end;
            }

            public int Length
            {
                get { return End - Start + 1; }
                set { }
            }

        }
    }
}
