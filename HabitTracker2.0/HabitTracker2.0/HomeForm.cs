using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HabitTracker2._0
{
    public partial class HomeForm : Form
    {
        private MySQLConnection conn;
        private int points;
        public HomeForm(MySQLConnection cnx)
        {
            InitializeComponent();
            conn = cnx;
            points = cnx.calculatePoints();
            pointsLabel.Text = points.ToString();

            if (points <= 1000)
            {
               LevelPictureBox.Image = Image.FromFile("lep200.png");
            }
            else if (points <= 2000)
            {
                LevelPictureBox.Image = Image.FromFile("fairy200.png");
            }
            else if (points <= 3500)
            {
                LevelPictureBox.Image = Image.FromFile("unicorn200.png");
            }
            else if (points <= 5000)
            {
                LevelPictureBox.Image = Image.FromFile("phoenix200.png");
            }
            else
            {
                LevelPictureBox.Image = Image.FromFile("dragon200.png");
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            conn.stopConnection();
            Application.Exit();
        }

        private void addHabitButton_Click(object sender, EventArgs e)
        {
            AddHabit add = new AddHabit(conn);
            this.Hide();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeiwForm veiwForm = new VeiwForm(conn);
            this.Hide();
            veiwForm.Show();
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            RecordForm recordForm = new RecordForm(conn);
            this.Hide();
            recordForm.Show();
        }
    }
}
