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
    public partial class RecordForm : Form
    {
        MySQLConnection cnx;
        public RecordForm(MySQLConnection conn)
        {
            InitializeComponent();
            cnx = conn;
            habitComboBox.DataSource = cnx.getHabits();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(cnx);
            this.Hide();
            home.Show();
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            string habit = habitComboBox.Text;
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            bool complete = cnx.record(habit,date);
            if (complete)
            {
                label3.Text = "recorded";
            }
        }
    }
}
