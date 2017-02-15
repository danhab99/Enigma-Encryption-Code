using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Enigma_Encrypter
{
    class Enigma
    {
        #region Codexes
        private string _rotor1;
        /// <summary>
        /// Rotor1's cypher
        /// </summary>
        public string Rotor1
        {
            get { return _rotor1; }
            set { PropEdit(value, ref _rotor1); }
        }
        
        private string _rotor2;
        /// <summary>
        /// Rotor2's cypher
        /// </summary>
        public string Rotor2
        {
            get { return _rotor2; }
            set { PropEdit(value, ref _rotor2); }
        }

        private string _rotor3;
        /// <summary>
        /// Rotor3's cypher
        /// </summary>
        public string Rotor3
        {
            get { return _rotor3; }
            set { PropEdit(value, ref _rotor3); }
        }
        
        private string _plugboard;
        /// <summary>
        /// The plugboard's cypher
        /// </summary>
        public string Plugboard
        {
            get { return _plugboard; }
            set { PropEdit(value, ref _plugboard); }
        }

        private void PropEdit(string input, ref string Prop)
        {
            if (input.Length == abc.Length)
            {
                Prop = input;
            }
            else
            {
                throw new CypherOfImproperLengthException("Cypher needs to be " + abc.Length.ToString() + " characters long");
            }
        }
        #endregion
        #region Positions
        private int _protor1;
        /// <summary>
        /// Rotor1's position
        /// </summary>
        public int pRotor1
        {
            get { return _protor1; }
            set { _protor1 = value; }
        }

        private int _protor2;
        /// <summary>
        /// Rotor2's position
        /// </summary>
        public int pRotor2
        {
            get { return _protor2; }
            set { _protor2 = value; }
        }

        private int _protor3;
        /// <summary>
        /// Rotor3's position
        /// </summary>
        public int pRotor3
        {
            get { return _protor3; }
            set { _protor3 = value; }
        }
        #endregion

        private string abc;

        /// <summary>
        /// Builds an Enigma machine based on the parameters
        /// </summary>
        /// <param name="rotor1">A string of characters that each ABC character will switch to</param>
        /// <param name="rotor1_p">The number of rotations the cypher in rotor1 will take</param>
        /// <param name="rotor2">A string of characters that each ABC character will switch to</param>
        /// <param name="rotor2_p">The number of rotations the cypher in rotor2 will take</param>
        /// <param name="rotor3">A string of characters that each ABC character will switch to</param>
        /// <param name="rotor3_p">The number of rotations the cypher in rotor3 will take</param>
        /// <param name="plugboard">A string of characters that each ABC character will switch to</param>
        public Enigma(
            string abc,
            string rotor1,
            int rotor1_p,
            string rotor2,
            int rotor2_p,
            string rotor3,
            int rotor3_p,
            string plugboard
            )
        {
            if (abc.Length % 2 != 0) throw new ArgumentException("abc must be even");
            this.abc = abc;
            Rotor1 = rotor1;
            Rotor2 = rotor2;
            Rotor3 = rotor3;
            Plugboard = plugboard;
            pRotor1 = rotor1_p;
            pRotor2 = rotor2_p;
            pRotor3 = rotor3_p;
        }

        public Enigma(string abc)
        {
            //if (abc.Length % 2 != 0) throw new ArgumentException("abc must be even");
            this.abc = abc;
        }

        private char Invert(char input)
        {
            double work = abc.IndexOf(input);
            //work = (1 - (int)(work / abc.Length)) * abc.Length;
            work /= abc.Length;
            work = 1 - work;
            work *= abc.Length;

            return abc[Convert.ToInt32(work)];
        }

        private char Switch(char input, string codex, int phase = 0)
        {
            string newABC = Rotate(abc, phase);
            string newCodex = Rotate(codex, phase);
            int index = newABC.IndexOf(input);
            return newCodex[index];
        }

        private char ISwitch(char input, string codex, int phase = 0)
        {
            string newABC = Rotate(abc, phase);
            string newCodex = Rotate(codex, phase);
            int index = newCodex.IndexOf(input);
            return newABC[index];
        }

        private string Rotate(string input, int phase)
        {
            string i = input;
            for (int x = 0; x < phase; x++)
            {
                char f = i[0];
                i += f;
                i = i.Remove(0, 1);  
            }
            return i;
        }
        
        private void Incriment()
        {
            int l = abc.Length;
            pRotor1++;
            if (pRotor1 > l)
            {
                pRotor1 -= l;
                pRotor2++;
            }
            if (pRotor2 > l)
            {
                pRotor2 -= l;
                pRotor3++;
            }
            if (pRotor3 > l)
            {
                pRotor3 -= l;
                pRotor1++;
            }
        }

        /// <summary>
        /// Returns a single encrypted character while incrimenting the rotors
        /// </summary>
        /// <param name="input">Character to encrypt</param>
        /// <returns>The encrypted character</returns>
        //http://enigma.louisedade.co.uk/howitworks.html
        public char Use(char input)
        {
            char work = input;

            Incriment();

            work = Switch(work, Plugboard); //Plugboard
            work = Switch(work, Rotor1, pRotor1); //First Rotor
            work = Switch(work, Rotor2, pRotor2); //Second Rotor
            work = Switch(work, Rotor3, pRotor3); //Third Rotor


            work = Invert(work); //Mirror

            work = ISwitch(work, Rotor3, pRotor3); //Third Rotor
            work = ISwitch(work, Rotor2, pRotor2); //Second Rotor
            work = ISwitch(work, Rotor1, pRotor1); //First Rotor
            work = ISwitch(work, Plugboard); //Plugboard

            return work;
        }
    }

    /// <summary>
    /// Thrown when a cypher is not 26 character's long
    /// </summary>
    [Serializable]
    public class CypherOfImproperLengthException : Exception
    {
        public CypherOfImproperLengthException() { }
        public CypherOfImproperLengthException(string message) : base(message) { }
        public CypherOfImproperLengthException(string message, Exception inner) : base(message, inner) { }
        protected CypherOfImproperLengthException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
