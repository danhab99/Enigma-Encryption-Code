using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Encryption_Code
{
    public class keyboard
    {
        #region Constructors
        public keyboard(string stream)
        {
            using (Stream io = GenerateStreamFromString(stream))
            {
                _keyboard(io);
            }
        }

        public keyboard(Stream stream)
        {
            _keyboard(stream);
        }

        private void _keyboard(Stream stream)
        {
            workStream = stream;
        }
        #endregion

        #region Properties
        private Stream _workStream;

        public Stream workStream
        {
            get { return _workStream; }
            set { _workStream = value; }
        }
        private byte[] _typed;

        public byte[] Typed
        {
            get { return _typed; }
        }
        #endregion

        private Stream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public void sendKey(byte i)
        {
            byte[] work = new byte[]{ i};
            _sendKey(work);
        }

        public void sendKey(char i)
        {
            byte[] work = new byte[] { (byte)i };
            _sendKey(work);
        }

        public void sendKeys(string i)
        {
            foreach (char item in i)
            {
                byte[] work = new byte[] { (byte)item };
                _sendKey(work);
            }
        }

        public void sendKey()
        {
            using (Stream io = workStream)
            {
                byte[] readed = new byte[1];
                io.Read(readed, (int)io.Position, 1);
                _sendKey(readed);
            }
        }

        private void _sendKey(byte[] i)
        {
            _typed = i;
        }
    }
}
