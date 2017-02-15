using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine.Enigma.Constituents.Exceptions
{

    [Serializable]
    public class ArrayComponentsContainDuplicatesException : Exception
    {
        public ArrayComponentsContainDuplicatesException() { }
        public ArrayComponentsContainDuplicatesException(string message) : base(message) { }
        public ArrayComponentsContainDuplicatesException(string message, Exception inner) : base(message, inner) { }
        protected ArrayComponentsContainDuplicatesException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
