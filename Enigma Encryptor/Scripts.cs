using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_Encryptor
{
    public static class Scripts
    {
        public static string ToString(this string[] s, int a)
        {
            if (a > 1)
            {
                string str = "[ ";
                for (int i = 0; i < a - 2; i++)
                {
                    str = str + s[i] + ", ";
                }
                str = str + s[s.Length - 1] + " ]";
                return str;
            }
            else
            {
                return s[0];
            }
        }

        public static void popTreeView(string path, ref TreeNode exit)
        {
            foreach (var item in Directory.GetFiles(path))
            {
                exit.Nodes.Add(item);
            }
            foreach (var item in Directory.GetDirectories(path))
            {
                TreeNode temp = exit.Nodes.Add(item);
                popTreeView(item, ref temp);
            }
        }

        public static void MoveItem(int direction, ListBox lb)
        {
            // Checking selected item
            if (lb.SelectedItem == null || lb.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = lb.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lb.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lb.SelectedItem;

            // Removing removable element
            lb.Items.Remove(selected);
            // Insert it in new position
            lb.Items.Insert(newIndex, selected);
            // Restore selection
            lb.SetSelected(newIndex, true);
        }

        public static byte[] GenerateABC()
        {
            List<byte> b = new List<byte>();
            for (int i = 0; i < byte.MaxValue+1; i++)
            {
                b.Add((byte)i);
            }
            return b.ToArray();
        }

        public static byte[] toByte(this string s)
        {
            return Encoding.ASCII.GetBytes(s.ToCharArray());
        }

        public static char[] ToCharArray(this byte[] b)
        {
            return Encoding.ASCII.GetChars(b);
        }

        public static void Fill(this TextBox tb, byte[] abc)
        {
            var t = new List<byte>(abc);
            t.Shuffle();
            tb.Text = Encoding.ASCII.GetString(t.ToArray());
        }

        public static void Shuffle<T>(this List<T> list)
        {
            var rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static void Fill(this NumericUpDown nud, int max)
        {
            nud.Value = new Random().Next(max);
        }
    }
}
