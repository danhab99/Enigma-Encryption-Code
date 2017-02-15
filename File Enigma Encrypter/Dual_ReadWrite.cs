using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace File_Enigma_Encrypter
{
    class Dual_ReadWrite
    {
        private FileStream reader;
        private FileStream writer;

        public Dual_ReadWrite(string read_from, string write_to)
        {
            reader = File.OpenRead(read_from);
            writer = File.OpenWrite(write_to);
        }

        public byte readByte()
        {
            return (byte)reader.ReadByte();
        }

        public void writeByte(byte b)
        {
            writer.WriteByte(b);
        }

        public long realLength()
        {
            return reader.Length;
        }

        public void flushWrite(bool flushtodisk)
        {
            writer.Flush(flushtodisk);
        }

        public void Dispose()
        {
            flushWrite(true);
            reader.Dispose();
            writer.Dispose();
        }
    }
}
