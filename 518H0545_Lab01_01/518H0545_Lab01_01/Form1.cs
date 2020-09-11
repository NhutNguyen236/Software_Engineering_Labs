using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _518H0545_Lab01_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Red_CheckedChanged(object sender, EventArgs e)
        {
            if (Red.Checked)
            {
                ResultTextbox.ForeColor = Color.Red;       
            }
        }

        private void ResultTextbox_TextChanged(object sender, EventArgs e)
        {
            String text = this.txtNhapten.Text;
            this.ResultTextbox.Text = text;
        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            String text = this.txtNhapten.Text;
            this.ResultTextbox.Text = text;
        }

        private void Green_CheckedChanged(object sender, EventArgs e)
        {
            if (Green.Checked)
            {
                ResultTextbox.ForeColor = Color.Green;
            }
        }

        private void Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (Blue.Checked)
            {
                ResultTextbox.ForeColor = Color.Blue;
            }
        }

        private void Orange_CheckedChanged(object sender, EventArgs e)
        {
            if (Orange.Checked)
            {
                ResultTextbox.ForeColor = Color.Orange;
            }
        }

        private void Bold_CheckedChanged(object sender, EventArgs e)
        {
            if (Bold.Checked)
            {
                ResultTextbox.Font = new Font("Arial", 13, FontStyle.Bold);
            }
        }

        private void Italic_CheckedChanged(object sender, EventArgs e)
        {
            if (Italic.Checked)
            {
                ResultTextbox.Font = new Font("Arial", 13, FontStyle.Italic);
            }
        }

        private void Underline_CheckedChanged(object sender, EventArgs e)
        {
            if (Underline.Checked)
            {
                ResultTextbox.Font = new Font("Arial", 13, FontStyle.Underline);
            }
        }
    }
}
