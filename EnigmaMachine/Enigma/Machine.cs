using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EnigmaMachine.Enigma;
using EnigmaMachine.Enigma.Constituents;
using EnigmaMachine.Enigma.Constituents.Extensions;
using System.IO;

namespace EnigmaMachine.Enigma
{
    /// <summary>
    /// Creates a new Enigma machine
    /// </summary>
    /// <typeparam name="T">The type of object to be worked on</typeparam>
    class Machine<T>
        where T: struct
    {
        private List<Plugboard<T>> _plugboards;
        /// <summary>
        /// The collection of all the plugboards
        /// </summary>
        public List<Plugboard<T>> Plugboards
        {
            get { return _plugboards; }
            set { _plugboards = value; }
        }

        private List<Rotor<T>> _rotors;
        /// <summary>
        /// The collection of all rotors
        /// </summary>
        public List<Rotor<T>> Rotors
        {
            get { return _rotors; }
            set { _rotors = value; }
        }

        private T[] abc;

        public Machine(T[] _abc)
        {
            abc = _abc;
        }

        /// <summary>
        /// Opperates on one object
        /// </summary>
        /// <param name="input">The object to operate on</param>
        /// <returns>An encrypted object</returns>
        public T SingleUse(T input)
        {
            T temp = input;

            temp = Plugboards.batchUse(temp, false);
            temp = Rotors.batchUse(temp, false);
            temp = Invert(temp, abc);
            temp = Rotors.batchUse(temp, true);
            temp = Plugboards.batchUse(temp, true);

            return temp;
        }

        /// <summary>
        /// Opperates on an array of objects
        /// </summary>
        /// <param name="input">An array of objects</param>
        /// <returns>The encrypted array of objects</returns>
        public IEnumerable<T> batchUse(T[] input)
        {
            List<T> l = new List<T>();
            foreach (var item in input)
            {
                l.Add(SingleUse(item));
            }
            return l.AsEnumerable();
        }

        /// <summary>
        /// Will opperate on a whole file
        /// </summary>
        /// <param name="read">Stream to read from</param>
        /// <param name="write">Stream to write to</param>
        /// <returns>The time the process took</returns>
        public async Task<int> massUse(StreamReader read, StreamWriter write)
        {
            var multi = new Task[8];
            for (int i = 0; i < 7; i++)
            {
                multi[i] = Task.Run(
                    //async () =>
                    //{
                    //    write.WriteLineAsync(
                    //        SingleUse(
                    //            )
                    //            );
                    //});
            }
        }

        private static T Invert(T input, T[] abc)
        {
            double work = new List<T>(abc).BinarySearch(input);
            //work = (1 - (int)(work / abc.Length)) * abc.Length;
            work /= abc.Length;
            work = 1 - work;
            work *= abc.Length;

            return abc[Convert.ToInt32(work)];
        }
    }
}
