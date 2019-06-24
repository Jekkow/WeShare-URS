using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WURS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.Login(Username.text, Password.text, 1);
        }

        private void Username_OnTextChange(object sender, EventArgs e)
        {

        }

        private void Password_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
