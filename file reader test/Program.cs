using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_reader_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, BitArray> converter = GenerateConversionTable(4, "abcdefghijklmnopqrstuvwxyz");
            string fromFile = ask("File to pull from");

            using (StreamReader i = new StreamReader(fromFile))
            {
                while (i.Peek() >= 0)
                {
                    char[] buffer = new char[32];
                    for (int j = 0; j < buffer.Length; j++)
                    {
                        buffer[j] = (char)i.Read();
                    }


                }
            }
        }

        private static Dictionary<char, BitArray> GenerateConversionTable(int Bit_Count, string Char_List)
        {
            Dictionary<char, BitArray> ret = new Dictionary<char, BitArray>();

            BitArray test = new BitArray(Bit_Count);
            for (int i = 0; i < Bit_Count; i++) { test.Set(i, true); }

            for (int i = 0; i < int.MaxValue; i++)
            {
                BitArray b = new BitArray(new int[] { i });
                BitArray r = new BitArray(Bit_Count);

                for (int j = 0; i < Bit_Count; j++) { r.Set(j, b.Get(j)); }

                ret.Add(Char_List[i], r);

                if (r == test)
                {
                    break;
                }
            }

            return ret;
        }

        private char findInDictionary(Dictionary<char, BitArray> dic, BitArray input)
        {
            char ret = ' ';
            foreach (KeyValuePair<char, BitArray> item in dic)
            {
                if (item.Value == input)
                {
                    ret = item.Key;
                }
            }
            return ret;
        }

        private static void Split(char[] input, ref List<BitArray> output)
        {
            byte[] work = new byte[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                work[i] = (byte)input[i];
            }

            for (int i = 0; i < work.Length; i++)
            {
                BitArray big = new BitArray(work[i]);
                BitArray halfA = new BitArray(4);
                BitArray halfB = new BitArray(4);

                halfA.Set(0, big.Get(0));
                halfA.Set(1, big.Get(1));
                halfA.Set(2, big.Get(2));
                halfA.Set(3, big.Get(3));

                halfB.Set(0, big.Get(4));
                halfB.Set(1, big.Get(5));
                halfB.Set(2, big.Get(6));
                halfB.Set(3, big.Get(7));

                output.Add(halfA);
                output.Add(halfB); 
            }
        }

        private static string ask(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();
        }
    }
}
