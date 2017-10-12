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

namespace WindFormsexam
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\ОмиржанН.CORP\Desktop\WindFormsexam\WindFormsexam\bin\Debug";
            
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
            textBoxRepeatPassword.Clear();
            textBoxEmail.Clear();
        }

        private void ButtonAutorizathion_Click(object sender, EventArgs e)
        {
            AutorizhtionWindow window = new AutorizhtionWindow();
            window.Show();
            this.Hide();
        }
    }
}
