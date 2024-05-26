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
    public partial class AddHabit : Form
    {
        MySQLConnection cnx;
        public AddHabit(MySQLConnection conn)
        {
            InitializeComponent();
            cnx = conn;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(cnx);
            this.Hide();
            home.Show();

        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            bool complete = cnx.newHabit(nameTextBox.Text, pointsTextBox.Text);

            if (complete)
            {
                completeLabel.Text = "Habit Added";
            }
            else
            {
                completeLabel.Text = "Was Unable To Complete Please Check Input";
            }
        }
    }
}
