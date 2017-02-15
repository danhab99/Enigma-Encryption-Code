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
        private char[] _rotor1;
        /// <summary>
        /// Rotor1's cypher
        /// </summary>
        public char[] Rotor1
        {
            get { return _rotor1; }
            set { PropEdit(value, ref _rotor1); }
        }

        private char[] _rotor2;
        /// <summary>
        /// Rotor2's cypher
        /// </summary>
        public char[] Rotor2
        {
            get { return _rotor2; }
            set { PropEdit(value, ref _rotor2); }
        }

        private char[] _rotor3;
        /// <summary>
        /// Rotor3's cypher
        /// </summary>
        public char[] Rotor3
        {
            get { return _rotor3; }
            set { PropEdit(value, ref _rotor3); }
        }

        private char[] _plugboard;
        /// <summary>
        /// The plugboard's cypher
        /// </summary>
        public char[] Plugboard
        {
            get { return _plugboard; }
            set { PropEdit(value, ref _plugboard); }
        }

        private void PropEdit(char[] input, ref char[] Prop)
        {
            if (input.Length == abc.Length)
            {
                Prop = input;
            }
            else
            {
                throw new CypherOfImproperLengthException("Cypher needs to be " + abc.Length.ToString() +" characters long");
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

        /// <summary>
        /// The character set to switch between
        /// </summary>
        public char[] abc { get; set; }

        /// <summary>
        /// Builds an Enigma machine based on the parameters
        /// </summary>
        /// <param name="abc">The character set to switch between</param>
        /// <param name="rotor1">A string of characters that each ABC character will switch to</param>
        /// <param name="rotor1_p">The number of rotations the cypher in rotor1 will take</param>
        /// <param name="rotor2">A string of characters that each ABC character will switch to</param>
        /// <param name="rotor2_p">The number of rotations the cypher in rotor2 will take</param>
        /// <param name="rotor3">A string of characters that each ABC character will switch to</param>
        /// <param name="rotor3_p">The number of rotations the cypher in rotor3 will take</param>
        /// <param name="plugboard">A string of characters that each ABC character will switch to</param>
        public Enigma(
            char[] abc,
            char[] rotor1,
            int rotor1_p,
            char[] rotor2,
            int rotor2_p,
            char[] rotor3,
            int rotor3_p,
            char[] plugboard
            )
        {
            this.abc = abc;
            Rotor1 = rotor1;
            Rotor2 = rotor2;
            Rotor3 = rotor3;
            Plugboard = plugboard;
            pRotor1 = rotor1_p;
            pRotor2 = rotor2_p;
            pRotor3 = rotor3_p;
        }

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
            this.abc = abc.ToCharArray();
            Rotor1 = rotor1.ToCharArray();
            Rotor2 = rotor2.ToCharArray();
            Rotor3 = rotor3.ToCharArray();
            Plugboard = plugboard.ToCharArray();
            pRotor1 = rotor1_p;
            pRotor2 = rotor2_p;
            pRotor3 = rotor3_p;
        }

        public Enigma(char[] abc)
        {
            this.abc = abc;
        }

        private char Invert(char input, char[] word)
        {
            int work = abc[input];

            if (abc.Length % 2 == 0) //Even
            {
                int gap = word[input];
                return word[word.Length - gap - 2];
            }
            else //Odd
            {
                int gap = input;
                return word[word.Length - gap - 1];
            }
        }

        private char Switch(char input, char[] codex, int phase = 0)
        {
            char[] newABC = Rotate(abc, phase);
            char[] newCodex = Rotate(codex, phase);
            int index = newABC[input];
            return newCodex[index];
        }

        private char ISwitch(char input, char[] codex, int phase = 0)
        {
            char[] newABC = Rotate(abc, phase);
            char[] newCodex = Rotate(codex, phase);
            int index = newCodex[input];
            return newABC[index];
        }

        private char[] Rotate(char[] input, int phase)
        {
            string i = new string(input);
            for (int x = 0; x < phase; x++)
            {
                char f = i[0];
                i += f;
                i = i.Remove(0, 1);
            }
            return i.ToCharArray() ;
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


            work = Invert(work, abc); //Mirror

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
