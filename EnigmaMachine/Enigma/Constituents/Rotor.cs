using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaMachine.Enigma.Constituents.Exceptions;
using EnigmaMachine.Enigma.Constituents.Interfaces;
using EnigmaMachine.Enigma.Constituents.Extensions;

namespace EnigmaMachine.Enigma.Constituents
{
    /// <summary>
    /// The rotor system for the Enigma encryptor
    /// </summary>
    /// <typeparam name="T">What kind of objects are being scrambled</typeparam>
    public class Rotor<T> : object, iter_Translator<T>
    {
        private T[] _Alphabet;
        /// <summary>
        /// The base code of objects, no repeats allowed
        /// </summary
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
        /// The synchronous offset for this device
        /// </summary>
        public int offset
        {
            get
            {
                //throw new NotImplementedException();
                offset++;
                return offset;
            }

            set
            {
                //throw new NotImplementedException();
                if (offset >= Alphabet.Length)
                {
                    next.offset = Alphabet.Length - offset;
                    offset = Alphabet.Length;
                }
                else
                {
                    offset = value;
                }
            }
        }

        public iter_Translator<T> next
        {
            get
            {
                //throw new NotImplementedException();
                return next;
            }

            set
            {
                //throw new NotImplementedException();
                next = value;
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
            return Use(input, invert, offset);
        }

        public T Use(T input, bool invert, int async_offset)
        {
            //throw new NotImplementedException();
            var o = async_offset;

            var a = new List<T>(Alphabet).rotate(async_offset);
            var c = new List<T>(Cypher).rotate(async_offset);

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
        /// Creates a new rotor
        /// </summary>
        /// <param name="abc">The clean alphabet</param>
        /// <param name="c">The scrambled cypher</param>
        /// <param name="of">The starting offset</param>
        public Rotor(T[] abc, T[] c, int of)
        {
            _Alphabet = abc;
            _Cypher = c;
            offset = of;
        }
    }
}
