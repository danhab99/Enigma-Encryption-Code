using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string zString = ask("String to replace 0(false): ");
            string oString = ask("String to replace 1(true): ");
            string delay = ask("Delay between steps: ");

            string fmt = "";
            foreach (char item in int.MaxValue.ToString())
            {
                fmt += "0";
            }
            fmt += ".##";

            for (int i = 0; i < int.MaxValue; i++)
            {
                byte[] tr = System.BitConverter.GetBytes(i);
                BitArray b = new BitArray(tr);

                string work = "";
                foreach (bool item in b)
                {
                    if (item)
                    {
                        work += oString;
                    }
                    else
                    {
                        work += zString;
                    }
                }

                string render = i.ToString(fmt) + "| " + work;
                Console.WriteLine(render);
                System.Threading.Thread.Sleep(Convert.ToInt32(delay));
            }
            Console.ReadKey();
        }

        private static string ask(string input)
        {
            Console.Write(input);
            string work = Console.ReadLine();
            Console.WriteLine("");
            return work;
        }
    }
}
