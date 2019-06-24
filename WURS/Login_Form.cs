using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WURS
{
    public partial class Login_Form : Form
    {
        public static int Attempt = 0; // amount of times user tried to login
        DAL DAL = new DAL(); 

        public Login_Form()
        {
            InitializeComponent();
            Password_Textbox.isPassword = true; // password box shows asteriks
            LoginAttempt.ForeColor = Color.Green; // 1st login attempt is always green
            LoginAttempt.Text = String.Format("Poging {0}", Attempt);
            DAL.CheckSession();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (DAL.OldUsername != Username_Textbox.Text) // check if new username is given and reset Attempt counter
            {
                Attempt = 0;
            }

            DAL.OldUsername = Username_Textbox.Text;

            this.Hide();
            DAL.Login(Username_Textbox.Text, Password_Textbox.Text, false); // send username, password and attempt to DAL
            this.Show();

            Attempt++; // increment attempt, this only happens if the user failed to login

            LoginAttempt.Text = String.Format("Poging {0}", Attempt);
            if (Attempt == 1) // wrong login once, change color to orange
                LoginAttempt.ForeColor = Color.Orange;
            else if (Attempt == 2) // wrong login twice, change color to red
                LoginAttempt.ForeColor = Color.Red;
            else if (Attempt >= 3) // block account and show unblock time
            {
                LoginAttempt.Text = String.Format("Geblokkeerd tot {0}", DAL.BlockedUntil);
            }
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username_Textbox.Text == "Gebruikersnaam")
            {
                Username_Textbox.Text = "";
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username_Textbox.Text == "")
            {
                Username_Textbox.Text = "Gebruikersnaam";
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password_Textbox.Text == "Wachtwoord")
            {
                Password_Textbox.Text = "";
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password_Textbox.Text == "")
            {
                Password_Textbox.Text = "Wachtwoord";
            }
        }

        private void Password_Visable_Click(object sender, EventArgs e)
        {
            if (Password_Textbox.isPassword == true)
            {
                Password_Textbox.isPassword = false;
            }
            else if (Password_Textbox.isPassword == false)
            {
                Password_Textbox.isPassword = true;
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Button_Click(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            e.Handled = false;
            e.SuppressKeyPress = false;
        }

        private void LoginAttempt_Click(object sender, EventArgs e)
        {

        }
    }
}
