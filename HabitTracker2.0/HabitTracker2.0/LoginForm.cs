using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabitTracker2._0
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            MySQLConnection conn = new MySQLConnection();
            bool c = conn.connect(userTextBox.Text,passTextBox.Text,serverTextBox.Text);
            c = true;
            if (c) { 

                HomeForm homeForm = new HomeForm(conn);
                this.Hide();
                homeForm.Show();
            }
            else {
                invalidLabel.Text = "Invalid Credentials Please Try Again";
                userTextBox.Text = "";
                passTextBox.Text = "";
                serverTextBox.Text = "";
            }
            
        }
    }
}
