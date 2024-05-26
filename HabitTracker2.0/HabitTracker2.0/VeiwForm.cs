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
    public partial class VeiwForm : Form
    {
        MySQLConnection cnx;
        public VeiwForm(MySQLConnection conn)
        {
            InitializeComponent();
            cnx = conn;
            List<string> habits = cnx.getHabits();
            habits.Insert(0, "all");
            habitComboBox.DataSource = habits;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InstanceListView.Items.Clear();
            List<string> list = cnx.filterInstances(habitComboBox.Text);
            foreach (string instance in list)
            {
                InstanceListView.Items.Add(instance);
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(cnx);
            this.Hide();
            home.Show();
        }
    }
}
