using Club_Start.Add.Data;
using Club_Start.Add.Data;
using Club_Start.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Club_Start
{
    public partial class MainForm : Form
    { 
        private enum CurrentTable { Sportsmen, Coaches, Attendances }
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
    }
}
