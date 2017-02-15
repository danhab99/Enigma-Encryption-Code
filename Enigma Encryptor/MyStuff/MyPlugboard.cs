using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Encryptor.MyStuff
{
    class MyPlugboard<T> : EnigmaMachine.Enigma.Constituents.Plugboard<T>
    {
        private string _label;

        public string Label
        {
            get { return _label; }
        }
        
        public MyPlugboard(T[] abc, T[] c, string label = "") : base(abc, c)
        {
            _label = label;
        }

        public override string ToString()
        {
            return Label + ":" + base.GetHashCode().ToString("N5");
        }
    }
}
