using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine.Enigma.Constituents.Exceptions
{

    [Serializable]
    public class CypherDoseNotConformToAlphabetException : Exception
    {
        public CypherDoseNotConformToAlphabetException() { }
        public CypherDoseNotConformToAlphabetException(string message) : base(message) { }
        public CypherDoseNotConformToAlphabetException(string message, Exception inner) : base(message, inner) { }
        protected CypherDoseNotConformToAlphabetException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    //internal class CypherDoseNotConformToAlphabetExceptionArgs<T>
    //{
    //    public T[] cypher { get; set; }
    //    public T[] alphabet { get; set; }

    //    public int difference
    //    {
    //        get
    //        {
    //            return cypher.Length - alphabet.Length;
    //        }
    //    }
    //}
}
