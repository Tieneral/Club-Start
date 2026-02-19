using System;
using Club_Start;
using Club_Start.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_Start.Add.Data
{
    public partial class AddCoach : Form
    {
        public Coaches coach;
        public AddCoach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coach = new Coaches()
            {
                Name = textBox1.Text,
                Surname = textBox2.Text,
                Last_Name = textBox3.Text,
                Specializtion = textBox4.Text
            };

            Club_Start.Add_Classes.AddData.AddCoaches(coach);
            this.Close();
        }
    }
}
