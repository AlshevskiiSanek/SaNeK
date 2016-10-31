using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                return;
            }
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                return;
            }
            textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            //fontDialog1.Font.
        }
    }
}
