using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Encryption_Code
{
    class RotorGroup
    {
        private Rotor _rotorA;
        public Rotor RotorA
        {
            get { return _rotorA; }
            set { _rotorA = value; }
        }

        private Rotor _rotorB;
        public Rotor RotorB
        {
            get { return _rotorB; }
            set { _rotorB = value; }
        }

        private Rotor _rotorC;
        public Rotor RotorC
        {
            get { return _rotorC; }
            set { _rotorC = value; }
        }

        private Reflector reflector = new Reflector();

        public RotorGroup(Rotor RotorA, Rotor RotorB, Rotor RotorC)
        {
            _rotorA = RotorA;
            _rotorA.Next = RotorB;

            _rotorB = RotorB;
            _rotorB.Next = RotorC;

            _rotorC = RotorC;
            _rotorC.Next = RotorA;
        }

        public byte[] Use(byte[] i)
        {
            char o = (char)i[0];
            o = RotorA.Use(o, true);
            o = RotorB.Use(o, true);
            o = RotorC.Use(o, true);
            o = reflector.Use(o); //Reflect
            o = RotorC.Use(o, false);
            o = RotorB.Use(o, false);
            o = RotorA.Use(o, false);
            return new byte[] { (byte)o };
        }
    }

    internal class Rotor
    {

        public Rotor(string codex)
        {
            _codex = codex.ToArray<char>();
        }

        private string abc = "abcdefghijklmnopqrstuvwxyz";

        private char[] _codex;
        public char[] Codex
        {
            get { return _codex; }
            set
            {
                if(value != _codex)
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

        private int _position;
        public int Position
        {
            get { return _position; }
            set
            {
                if(value != _position)
                {
                    if (value > 26)
                    {
                        Position = value - 26;
                        Next.Position++;
                    }
                    else if (value < 26)
                    {
                        _position = value;
                    }
                }
            }
        }



        public Rotor Next { get; set; }

        public char Use(char i, bool tick)
        {
            char[] rotatedCodex = Rotate(Position);
            char o = abc[abc.IndexOf(i)];
            if (tick)
            {
                Position++; 
            }
            return o;
        }

        public char[] Rotate(int pos)
        {
            LinkedList<char> work = new LinkedList<char>(Codex);
            LinkedListNode<char> first = work.First;
            work.RemoveFirst();
            work.AddLast(first);

            return work.ToArray<char>();
        }
    }

    internal class CodexIsAnUnexceptableSize : Exception
    {
        public CodexIsAnUnexceptableSize()
        {
        }
    }

    internal class Reflector
    {
        private string abc = "abcdefghijklmnopqrstuvwxyz";
        private string cba = "zyxwvutsrqponmlkjihgfedcba";

        public char Use(char i)
        {
            char o = abc[cba.IndexOf(i)];
            return o;
        }
    }
}
