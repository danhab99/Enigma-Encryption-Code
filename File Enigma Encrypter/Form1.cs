using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Enigma_Encrypter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            List<char> abc = new List<char>();

            for (int i = 0; i < Byte.MaxValue; i++)
            {
                byte work = (byte)i;
                bool[] t = new bool[8];
                (new BitArray(new byte[] { work })).CopyTo(t, 0);
                char c = (char)i;

                abc.Add(c);
            }

            this.abc = abc.ToArray();

            m = new Enigma(new string(this.abc));
        }


        char[] abc;

        #region Uses
        private void button1_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.Cancel) { return; }
            txb_url.Text = openDialog.FileName;
        }
        private void SRandomFill(object sender, EventArgs e)
        {
            TextBox worker = (TextBox)sender;
            List<char> work = new List<char>(abc.Length);
            List<char> History = new List<char>();
            Random r = new Random();

            do
            {
                char test = abc[r.Next(abc.Length)];
                if (!History.Contains(test))
                {
                    work.Add(test);
                    History.Add(test);
                }
            } while (work.Count < abc.Length);

            if (work.Count != abc.Length)
            {
                throw new ArgumentException(work.Count.ToString());
            }

            worker.Text = new string(work.ToArray());

            switch (worker.Name)
            {
                case "txb_Codex_Rotor1":
                    m.Rotor1 = new string(work.ToArray());
                    break;
                case "txb_Codex_Rotor2":
                    m.Rotor2 = new string(work.ToArray());
                    break;
                case "txb_Codex_Rotor3":
                    m.Rotor3 = new string(work.ToArray());
                    break;
                case "txb_Plugboard":
                    m.Plugboard = new string(work.ToArray());
                    break;
                default:
                    throw new ArgumentException("Failed");
            }
        }
        private void IRandomFill(object sender, EventArgs e)
        {
            NumericUpDown worker = (NumericUpDown)sender;
            int work;
            Random r = new Random();

            work = r.Next(1, abc.Length - 1);

            worker.Value = work;

            switch (worker.Name)
            {
                case "num_Position_Rotor1":
                    m.pRotor1 = work;
                    break;
                case "num_Position_Rotor2":
                    m.pRotor2 = work;
                    break;
                case "num_Position_Rotor3":
                    m.pRotor3 = work;
                    break;
                default:
                    throw new ArgumentException("Failed");
            }
        } 
        #endregion

        Enigma m;
        Enigma untouched;
        Dual_ReadWrite drw;
        private void btn_Position_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.Cancel) { return; }
            drw = new Dual_ReadWrite(txb_url.Text, saveDialog.FileName);
            untouched = m;

            prb_FileProgress.Value = 0;
            prb_FileProgress.Maximum = (int)drw.realLength();

            for (long i = 0; i < drw.realLength(); i++)
            {
                drw.writeByte(
                    (byte)m.Use(
                        (char)drw.readByte()
                        )
                        );
                prb_FileProgress.Value++;
            }
            drw.Dispose();
        }
    }
}
    
[Serializable]
public class NotFoundException : Exception
{
    public NotFoundException() { }
    public NotFoundException(string message) : base(message) { }
    public NotFoundException(string message, Exception inner) : base(message, inner) { }
    protected NotFoundException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}