using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_02_518H0545
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure about quitting this form?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://vnexpress.net/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string error_caption = "Error";

            if (string.IsNullOrEmpty(EmployeeName.Text))
            {
                var emp_error = MessageBox.Show("Employee Name cannot be left empty", error_caption, MessageBoxButtons.OK);
                EmployeeName.Focus();
            }

            else if (!BirthDate.MaskCompleted || !BirthDate.MaskFull)
            {
                var emp_error = MessageBox.Show("Birth date is not filled or not finished yet", error_caption, MessageBoxButtons.OK);
                BirthDate.Focus();
            }

            else if (string.IsNullOrEmpty(Address.Text))
            {
                var emp_error = MessageBox.Show("Address is cannot be left empty", error_caption, MessageBoxButtons.OK);
                Address.Focus();
            }

            else if (City.SelectedIndex < 0)
            {
                var emp_error = MessageBox.Show("Please choose a city", error_caption, MessageBoxButtons.OK);
                City.Focus();
            }

            else if (Country.SelectedIndex < 0)
            {
                var emp_error = MessageBox.Show("Please choose your nation", error_caption, MessageBoxButtons.OK);
                Country.Focus();
            }

            else if (Qualification.SelectedIndex < 0)
            {
                var emp_error = MessageBox.Show("Please choose your highest qualification", error_caption, MessageBoxButtons.OK);
                Qualification.Focus();
            }


            else if (!Phone.MaskCompleted)
            {
                var emp_error = MessageBox.Show("Please enter your phone number", error_caption, MessageBoxButtons.OK);
                Phone.Focus();
            }

            else if (string.IsNullOrEmpty(Email.Text))
            {
                var emp_error = MessageBox.Show("Please enter your Email", error_caption, MessageBoxButtons.OK);
                Email.Focus();
            }

            else if (JoinDate.Text.Length == 0)
            {
                var emp_error = MessageBox.Show("When did you join this company?", error_caption, MessageBoxButtons.OK);
                JoinDate.Focus();
            }

            else
            {
                string message = "Employee Name: " + this.EmployeeName.Text
                                + "\nDate of birth: " + this.BirthDate.Text
                                + "\nAddress: " + this.Address.Text
                                + "\nCity: " + this.City.Text
                                + "\nCountry: " + this.Country.Text
                                + "\nQualification: " + this.Qualification.Text
                                + "\nPhone: " + this.Phone.Text
                                + "\nEmail: " + this.Email.Text
                                + "\nDate of joining: " + this.JoinDate.Text;
                string caption = "Information detail";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }
    }
}
