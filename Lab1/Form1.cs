using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Init : Form
    {
        public Init()
        {           
            InitializeComponent();
            //password.Text = "";
            //password.PasswordChar = '*';
            //password.MaxLength = 14;
            InitializeMyControl();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void InitializeMyControl()
        {
            password.Text = "";
            password.UseSystemPasswordChar = true;
            password.MaxLength = 14;
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (login.Text != "AlexLaim" | password.Text != "12345")
            {
                MessageBox.Show("Wrong login or password!");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();               
            }
        }

        
    }
}

