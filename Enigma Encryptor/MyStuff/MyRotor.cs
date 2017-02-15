using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Encryptor.MyStuff
{
    class MyRotor<T> : EnigmaMachine.Enigma.Constituents.Rotor<T>
    {
        private string _label;

        public string Label
        {
            get { return _label; }
        }
        public MyRotor(T[] abc, T[] c, int of, string lable = "") : base(abc, c, of)
        {
            _label = lable;
        }

        public override string ToString()
        {
            return Label + ":" + base.GetHashCode().ToString("N5");
        }
    }
}
