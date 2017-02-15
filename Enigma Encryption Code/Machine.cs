using Enigma_Encryption_Code.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Enigma_Encryption_Code
{
    class Machine
    {
        #region Components
        private keyboard _keyboard;

        public keyboard Keyboard
        {
            get { return _keyboard; }
            set { _keyboard = value; }
        }

        private RotorGroup _rotors;

        public RotorGroup Rotors
        {
            get { return _rotors; }
            set { _rotors = value; }
        }

        private plugBoard _plugBoard;

        public plugBoard Plugboard
        {
            get { return _plugBoard; }
            set { _plugBoard = value; }
        }

        private lightBoard _lightBoard;

        public lightBoard LightBoard
        {
            get { return _lightBoard; }
            set { _lightBoard = value; }
        }
        
        #endregion

        #region Properties
        private System.Windows.Forms.ProgressBar _progressbar;

        public System.Windows.Forms.ProgressBar Progressbar
        {
            get { return _progressbar; }
            set { _progressbar = value; }
        }
        #endregion

        public Machine() { }

        public Machine(keyboard Keyboard, RotorGroup Rotors, plugBoard Plugboard, lightBoard LightBoard)
        {
            _keyboard = Keyboard;
            _rotors = Rotors;
            _plugBoard = Plugboard;
            _lightBoard = LightBoard;
        }

        public void Operate(string i)
        {
            // convert string to stream
            byte[] byteArray = Encoding.UTF8.GetBytes(i);
            //byte[] byteArray = Encoding.ASCII.GetBytes(contents);
            MemoryStream stream = new MemoryStream(byteArray);
            
            LightBoard.OutPut = _operate(stream);
        }

        public void Operate(Stream i)
        {
            _operate(i);
        }

        private string _operate(Stream i)
        {
            Keyboard.workStream = i;
            Keyboard.sendKey();
            byte[] work = Keyboard.Typed;

            work = Plugboard.Use(work);

            work = Rotors.Use(work);

            work = Plugboard.Use(work);

            LightBoard.Use(work, i);
            
            using (StreamReader input = new StreamReader(i))
            {
                return input.ReadToEnd();
            }
        }
    }
}
