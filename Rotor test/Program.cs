using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotor_test
{
    class Program
    {
        public static string abc = "abcdefghijklmnopqrstuvwxyz";
        public static int position1 = 16;
        public static int position2 = 12;
        public static int position3 = 9;
        public static string plugboard = "QYHOGNECVPUZTFDJAXWMKISRBL".ToLower();
        public static string codex1 = "JGDQOXUSCAMIFRVTPNEWKBLZYH".ToLower();
        public static string codex2 = "NTZPSFBOKMWRCJDIVLAEYUXHGQ".ToLower();
        public static string codex3 = "JVIUBHTCDYAKEQZPOSGXNRMWFL".ToLower();

        static void Main(string[] args)
        {
            Console.WriteLine("Input word:");
            string input = Console.ReadLine();

            string work = "";
            foreach (char item in input)
            {
                Incriment();
                char w = item;

                w = Switch(w, plugboard);
                w = Switch(w, codex1, position);
                w = Switch(w, codex2, position);
                w = Switch(w, codex3, position);

                w = Invert(w);

                w = ISwitch(w, codex3, position);
                w = ISwitch(w, codex2, position);
                w = ISwitch(w, codex1, position);
                w = ISwitch(w, plugboard);
                work += w;
            }

            Console.WriteLine("Responce = " + work);
            Console.ReadKey();
        }
        
        private static char Switch(char input, string codex, int phase = 0)
        {
            string newABC = Rotate(abc, phase);
            string newCodex = Rotate(codex, phase);
            int index = newABC.IndexOf(input);
            return newCodex[index];
        }

        private static char ISwitch(char input, string codex, int phase = 0)
        {
            string newABC = Rotate(abc, phase);
            string newCodex = Rotate(codex, phase);
            int index = newCodex.IndexOf(input);
            return newABC[index];
        }

        private static string Rotate(string input, int phase)
        {
            string i = input;
            for (int x = 0; x < phase; x++)
            {
                char f = i[0];
                i += f;
                i = i.Remove(0, 1);
            }
            return i;
        }

        private static void Incriment()
        {
            position++;
            if (position > 26)
            {
                position -= 26;
            }
        }

        private static char Invert(char input)
        {
            int work = abc.IndexOf(input);
            work = Math.Abs(-(work - 25));

            return abc[work];
        }
    }
}
