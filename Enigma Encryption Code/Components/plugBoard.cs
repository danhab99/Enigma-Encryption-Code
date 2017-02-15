using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Encryption_Code.Components
{
    class plugBoard
    {
        private string abc = "abcdefghijklmnopqrstuvwxyz";

        private char[] _codex;

        public char[] Codex
        {
            get { return _codex; }
            set
            {
                if (value != _codex)
                {
                    if (value.Length == 26)
                    {
                        _codex = value;
                    }
                    else
                    {
                        throw new CodexIsAnUnexceptableSize();
                    }
                }
            }
        }

        public byte[] Use(byte[] i)
        {
            char o = Codex[abc.IndexOf( (char)i[0] )];
            byte[] oo = new byte[] { (byte)o };
            return oo;
        }
    }
}
