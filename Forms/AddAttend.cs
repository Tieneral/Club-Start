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
using Club_Start.Add_Classes;

namespace Club_Start.Forms
{
    public partial class AddAttend : Form
    {
        public Attendances attend;
        private bool isAdd = true;

        public AddAttend(Attendances? attend = null)
        {
            InitializeComponent();

            // Устанавливаем значения по умолчанию
            dateTimePicker1.Value = DateTime.Now;
            checkBox1.Checked = false; // По умолчанию "не был"

            if (attend != null)
            {
                // Заполняем поля данными из существующей записи
                textBox1.Text = attend.Sportsman_id?.Id.ToString() ?? "";
                textBox2.Text = attend.Coach_id?.Id.ToString() ?? "";
                dateTimePicker1.Value = attend.Training_Date;
                checkBox1.Checked = attend.Attended;

                isAdd = false;
                this.attend = attend;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sportsmanId = int.Parse(textBox1.Text);
                int coachId = int.Parse(textBox2.Text);

                // Получаем объекты спортсмена и тренера по ID
                var sportsman = Attendances.GetSportsmens(sportsmanId);
                var coach = Attendances.GetCoaches(coachId);

                if (isAdd)
                {
                    attend = new Attendances
                    {
                        Sportsman_id = sportsman,
                        Coach_id = coach,
                        Training_Date = dateTimePicker1.Value,
                        Attended = checkBox1.Checked
                    };

                    AddData.AddAttendances(attend);
                }
                this.Close();
            }
            finally { }
        }
    }
}