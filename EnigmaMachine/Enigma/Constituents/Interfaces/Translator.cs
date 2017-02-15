using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine.Enigma.Constituents.Interfaces
{
    public interface Translator<T>
    {
        /// <summary>
        /// Operates the current device
        /// </summary>
        /// <param name="input">The object to operate on</param>
        /// <param name="invert">Whether or not to flip the procedure</param>
        /// <returns>The encrypted object</returns>
        T Use(T input, bool invert);
        
        /// <summary>
        /// The scrambled cypher for this device, no repeats allowed
        /// </summary>
        T[] Cypher { get; }

        /// <summary>
        /// The base code of objects, no repeats allowed
        /// </summary>
        T[] Alphabet { get; }
    }
}
