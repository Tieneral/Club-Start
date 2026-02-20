using Club_Start.Add.Data;
using Club_Start.Add.Data;
using Club_Start.Forms;
using Club_Start.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Club_Start
{
    public partial class MainForm : Form
    {
        private enum CurrentTable { Sportsmen, Coaches, Attendances, MissedAttendance, PizdykActivity }
        private CurrentTable _currentTable = CurrentTable.Sportsmen;
        public MainForm()
        {
            InitializeComponent();
            dgv.KeyDown += dgv_KeyDown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClubDatabase.GetSportsmens();
            _currentTable = CurrentTable.Sportsmen;
            dgv.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClubDatabase.GetCoaches();
            _currentTable = CurrentTable.Coaches;
            dgv.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClubDatabase.GetAttendances();
            _currentTable = CurrentTable.Attendances;
            dgv.Focus();
        }

        private void btn4SportAdd_Click(object sender, EventArgs e)
        {
            var addForm = new Club_Start.Add.Data.AddSportsmenInBase();
            addForm.FormClosing += AddSportsmen_FormClosing;
            addForm.ShowDialog();
        }
        private void AddSportsmen_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<Sportsmens>? sportsmens = dgv.DataSource as List<Sportsmens>;
            sportsmens.Add(((AddSportsmenInBase)sender).sportsmens);
            dgv.DataSource = null;
            dgv.DataSource = sportsmens;
        }

        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            AddCoach addCoach = new AddCoach();
            addCoach.FormClosing += AddCoach_FormClosing;
            addCoach.ShowDialog();
        }

        private void AddCoach_FormClosing(object? sender, FormClosingEventArgs e)
        {
            List<Coaches>? coaches = dgv.DataSource as List<Coaches>;
            coaches.Add(((AddCoach)sender).coach);
            dgv.DataSource = null;
            dgv.DataSource = coaches;
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(2024, 1, 1);
            DateTime endDate = new DateTime(2024, 1, 31);

            dgv.DataSource = ClubDatabase.GetMissedAttendances(startDate, endDate);
            _currentTable = CurrentTable.MissedAttendance;
            dgv.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClubDatabase.PizdykActivity();
            _currentTable = CurrentTable.PizdykActivity;
            dgv.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddAttend addAttend = new AddAttend();
            addAttend.FormClosing += AddAttend_FormClosing;
            addAttend.ShowDialog();
        }

        private void AddAttend_FormClosing(object? sender, FormClosingEventArgs e)
        {
            List<Attendances>? attendances = dgv.DataSource as List<Attendances>;
            attendances.Add(((AddAttend)sender).attend);
            dgv.DataSource = null;
            dgv.DataSource = attendances;
        }
    }
}
