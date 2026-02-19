using System;
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
    public partial class AddSportsmenInBase : Form
    {
        public Sportsmens sportsmens;
        public AddSportsmenInBase()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ShowUpDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sportsmens = new Sportsmens()
            {
                Name = textBox1.Text,
                Surname = textBox2.Text,
                Last_Name = textBox3.Text,
                Birth_Date = dateTimePicker1.Value.Date,
                Parent_Phone = textBox4.Text
            };
            Club_Start.Add_Classes.AddData.AddSportsmens(sportsmens);
            this.Close();
        }
    }
}
