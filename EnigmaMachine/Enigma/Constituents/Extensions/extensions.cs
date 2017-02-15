using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaMachine.Enigma.Constituents.Interfaces;

namespace EnigmaMachine.Enigma.Constituents.Extensions
{
    public static class extensions
    {
        /// <summary>
        /// Rotates this list by moving the last object to the first position
        /// </summary>
        /// <typeparam name="T">The type of the list</typeparam>
        /// <param name="l">This list</param>
        /// <param name="by">How many times to repeat this procedure</param>
        /// <returns>The newly rotated list</returns>
        public static List<T> rotate<T>(this List<T> l, int by)
        {
            var ind = new List<T>(l.ToArray());
            for (int i = 0; i < by; i++)
            {
                ind.Insert(0, ind.First());
                ind.RemoveAt(ind.Count - 1);
            }
            return ind;
        }

        public static List<T> bindChildren<T>(this List<T> l)
            where T: iter_Translator<T>
        {
            var lis = new List<T>(l.ToArray());
            for (int i = 0; i < lis.Count-1; i++)
            {
                lis[i].next = lis[++i];
            }
            return lis;
        }

        public static List<T> incrimentBy<T>(this List<T> l, int i = 1)
            where T : iter_Translator<T>
        {
            var lis = new List<T>(l.ToArray());
            lis.First().offset += i;
            return lis;
        }

        public static T batchUse<T>(this List<Plugboard<T>> l, T input, bool inv)
        {
            var temp = input;
            for (int i = 0; i < l.Count; i++)
            {
                temp = l[i].Use(temp, inv);
            }
            return temp;
        }

        public static T batchUse<T>(this List<Rotor<T>> l, T input, bool inv)
        {
            var temp = input;
            for (int i = 0; i < l.Count; i++)
            {
                l[i].Use(temp, inv);
            }
            return temp;
        }
    }
}
