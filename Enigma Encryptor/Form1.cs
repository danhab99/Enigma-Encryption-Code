using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EnigmaMachine.Enigma.Constituents;
using Enigma_Encryptor.MyStuff;

namespace Enigma_Encryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[] abc = Scripts.GenerateABC();

        private void btn_FileDialog_Click(object sender, EventArgs e)
        {
            if (OFD_OpenFile.ShowDialog() == DialogResult.Cancel) return;
            txb_RootFolder.Text = OFD_OpenFile.FileNames.ToString(OFD_OpenFile.FileNames.Length);
        }

        private void btn_FolderDialog_Click(object sender, EventArgs e)
        {
            if (FBD_FindFolder.ShowDialog() == DialogResult.Cancel) return;
            txb_RootFolder.Text = FBD_FindFolder.SelectedPath;
        }

        private void txb_RootFolder_TextChanged(object sender, EventArgs e)
        {
            tv_Files.Nodes.Clear();

            if (File.GetAttributes(txb_RootFolder.Text) == FileAttributes.Directory)
            {
                TreeNode tnc = new TreeNode();
                Scripts.popTreeView(txb_RootFolder.Text, ref tnc);

                foreach (TreeNode item in tnc.Nodes)
                {
                    tv_Files.Nodes.Add(item);
                }
            }
            else
            //if (File.GetAttributes(txb_RootFolder.Text) == FileAttributes.Normal)
            {
                tv_Files.Nodes.Add(txb_RootFolder.Text);
            }
        }

        private void tv_Files_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            wb_Display.Url = new Uri(@e.Node.Text);
        }

        private void btn_Plugboards_MoveUp_Click(object sender, EventArgs e)
        {
            Scripts.MoveItem(1, lsb_Plugboards);
        }

        private void btn_Plugboards_MoveDown_Click(object sender, EventArgs e)
        {
            Scripts.MoveItem(-1, lsb_Plugboards);
        }

        private void btn_Rotors_MoveUp_Click(object sender, EventArgs e)
        {
            Scripts.MoveItem(1, lsb_Plugboards);
        }

        private void btn_Rotors_MoveDown_Click(object sender, EventArgs e)
        {
            Scripts.MoveItem(-1, lsb_Plugboards);
        }

        private void btn_Plugboards_Add_Click(object sender, EventArgs e)
        {
            var temp = new MyPlugboard<byte>(abc, txb_Plugboards_Cypher.Text.toByte(), txb_Plugboards_Name.Text);
            lsb_Plugboards.Items.Add(temp);
        }

        private void btn_Plugboards_Delete_Click(object sender, EventArgs e)
        {
            lsb_Plugboards.Items.RemoveAt(lsb_Plugboards.SelectedIndex);
        }

        private void btn_Rotors_Add_Click(object sender, EventArgs e)
        {
            var temp = new MyRotor<byte>(
                txb_Rotors_Cypher.Text.toByte(),
                abc,
                Convert.ToInt32(num_Rotors_IP.Value),
                txb_Rotors_Name.Text
                );
            lsb_Rotors.Items.Add(temp);
        }

        private void btn_Rotors_Delete_Click(object sender, EventArgs e)
        {
            lsb_Rotors.Items.RemoveAt(lsb_Rotors.SelectedIndex);
        }

        private void FillTextBox(object sender, EventArgs e)
        {
            (sender as TextBox).Fill(abc);
        }
    }
}
