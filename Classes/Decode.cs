using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Crypto
{
    class Decode
    {
        const string baseTextFile = "basetext.txt";
        const string baseTableFile = "basetable.txt";

        static Dictionary<string, int> baseFrequencyTable = null;
        static List<string> baseFrequencyList = null;

        public string DecodeCaesar(string input)
        {
            LoadBaseTable();
            CryptoCyphers decode = new CryptoCyphers();
            TextBox tetet = new TextBox();
            

            Dictionary<string, int> currentFrequencyTable = AnalyseText(input);
            List<string> currentFrequencyList = currentFrequencyTable.Keys.OrderByDescending(k => currentFrequencyTable[k]).ToList();

            int baseMax = 20;
            int currentMax = 20;

            string output = "";

            Cyphers caesar = new Cyphers();

            for (int i = 0; i < Math.Min(baseMax, currentFrequencyList.Count); i++)
            {
                for (int j = 0; j < Math.Min(currentMax, baseFrequencyList.Count); j++)
                {
                    if (IsComparable(baseFrequencyList[j], currentFrequencyList[i]))
                    {
                        int[] baseT = caesar.GetInputCode(baseFrequencyList[j]);
                        int[] currentT = caesar.GetInputCode(currentFrequencyList[i]);
                        int key = 0;
                        if (baseT[0] <= currentT[0])
                        {
                            key = currentT[0] - baseT[0];
                        }
                        else
                        {
                            key = caesar.GeneralLength - baseT[0] + currentT[0];
                        }

                        // output = "There are all variants:";
                        output += string.Format("\n\r\n{0}\n\r\n", caesar.DecryptCaesar(input, key.ToString()));
                    }
                }
            }

            return output;
        }

        static void LoadBaseTable()
        {
            try
            {
                if (File.Exists(baseTableFile))
                {
                    baseFrequencyTable = new Dictionary<string, int>();
                    baseFrequencyList = new List<string>();

                    string[] lines = null;
                    using (StreamReader reader = new StreamReader(baseTableFile))
                    {
                        lines = reader.ReadToEnd().Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    }
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] pair = lines[i].Split(' ');
                        baseFrequencyList.Add(pair[0]);
                        baseFrequencyTable.Add(pair[0], int.Parse(pair[1]));
                    }
                    baseFrequencyList = baseFrequencyTable.Keys.OrderByDescending(k => baseFrequencyTable[k]).ToList();
                }
                else
                {
                    string baseText = null;
                    using (StreamReader reader = new StreamReader(baseTextFile))
                    {
                        baseText = reader.ReadToEnd();
                    }

                    baseFrequencyTable = AnalyseText(baseText);
                    baseFrequencyList = baseFrequencyTable.Keys.OrderByDescending(k => baseFrequencyTable[k]).ToList();

                    using (StreamWriter writer = new StreamWriter(baseTableFile))
                    {
                        for (int i = 0; i < baseFrequencyList.Count; i++)
                        {
                            writer.WriteLine(baseFrequencyList[i] + " " + baseFrequencyTable[baseFrequencyList[i]]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static bool IsComparable(string baseFre, string currentFre)
        {
            if (string.IsNullOrEmpty(baseFre) || string.IsNullOrEmpty(currentFre) || baseFre.Length != currentFre.Length)
                return false;
            Cyphers caesar = new Cyphers();
            int[] baseT = caesar.GetInputCode(baseFre);
            int[] currentT = caesar.GetInputCode(currentFre);          
            int difference = 0;
            if (baseT[0] <= currentT[0])
            {
                difference = currentT[0] - baseT[0];
            }
            else
            {
                difference = caesar.GeneralLength - baseT[0] + currentT[0];
            }

            string compared = caesar.DecryptCaesar(currentFre[1].ToString(), difference.ToString());
            char[] comparedLetter = compared.ToCharArray();
            if (baseFre[1] == comparedLetter[0])
            {
                return true;
            }
            return false;
        }

        static Dictionary<string, int> AnalyseText(string text)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i - 1] >= 'A' && text[i - 1] <= 'z' && text[i] >= 'A' && text[i] <= 'z')
                {
                    string key = text.Substring(i - 1, 2);
                    if (!result.ContainsKey(key))
                    {
                        result.Add(key, 0);
                    }
                    result[key]++;
                }
            }

            return result;
        }
    }
}
