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
    public partial class AutorizhtionWindow : Form
    {
        Registration registration;
        MainMenu mainMenu;
        public AutorizhtionWindow()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            using (FileStream file= File.Open("LoginPassword.txt", FileMode.Open))
            {
                mainMenu = new MainMenu();
                byte[] bytes = new byte[file.Length];
                file.Read(bytes, 0, bytes.Length);
                string data = Encoding.ASCII.GetString(bytes);
                string[] loginAndPassowrd = data.Split(';');
                loginAndPassowrd[1] = loginAndPassowrd[1].TrimEnd(' ');
                if ((textBoxLogin.Text == loginAndPassowrd[0]) && (textBoxPassword.Text == loginAndPassowrd[1]))
                {
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                }
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonOK_Click(sender,e);
            }
        }

        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}
