using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] p, f;



        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                f = openFileDialog1.SafeFileNames;
                p = openFileDialog1.FileNames;
            }
            for (int i = 0; i < f.Length; i++)
            {
                listBox1.Items.Add(f[i]);
            }
        }


        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.URL = p[listBox1.SelectedIndex];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = p[listBox1.SelectedIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
