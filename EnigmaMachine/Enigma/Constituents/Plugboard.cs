using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaMachine.Enigma.Constituents.Exceptions;
using EnigmaMachine.Enigma.Constituents.Interfaces;

namespace EnigmaMachine.Enigma.Constituents
{
    /// <summary>
    /// The plugboard system for the Enigma encryptor
    /// </summary>
    /// <typeparam name="T">What kind of objects are being scrambled</typeparam>
    public class Plugboard<T> : object, Translator<T>
    {
        private T[] _Alphabet;
        /// <summary>
        /// The base code of objects, no repeats allowed
        /// </summary>
        public T[] Alphabet
        {
            get
            {
                //throw new NotImplementedException();
                return _Alphabet;
            }
        }

        private T[] _Cypher;
        /// <summary>
        /// The scrambled cypher for this device, no repeats allowed
        /// </summary>
        public T[] Cypher
        {
            get
            {
                //throw new NotImplementedException();
                return _Cypher;
            }
        }

        /// <summary>
        /// Operates the current device
        /// </summary>
        /// <param name="input">The object to operate on</param>
        /// <param name="invert">Whether or not to flip the procedure</param>
        /// <returns>The encrypted object</returns>
        public T Use(T input, bool invert)
        {
            //throw new NotImplementedException();
            var a = new List<T>(Alphabet);
            var c = new List<T>(Cypher);

            if (!invert)
            {
                return c[a.IndexOf(input)];
            }
            else
            {
                return a[c.IndexOf(input)];
            }
        }

        /// <summary>
        /// Creates a new plugboard
        /// </summary>
        /// <param name="abc">The clean alphabet</param>
        /// <param name="c">The scrambled cypher</param>
        public Plugboard(T[] abc, T[] c)
        {
            _Alphabet = abc;
            _Cypher = c;
        }
    }
}
