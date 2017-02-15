using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Encryption_Code.Components
{
    class lightBoard
    {
        public void Use(byte[] i, Stream io)
        {
            io.Write(
                i,
                Convert.ToInt32(i),
                1
                );

            using (StreamReader input = new StreamReader(io))
            {
                OutPut =  input.ReadToEnd();
            }
        }

        private string _output;

        public string OutPut
        {
            get { return _output; }
            set { _output = value; }
        }


    }
}
