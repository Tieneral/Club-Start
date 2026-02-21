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
        private enum CurrentTable { Sportsmen, Coaches, Attendances, MissedAttendance, PizdykActivity, CoachStats }
        private CurrentTable _currentTable = CurrentTable.Sportsmen;
        public MainForm()
        {
            InitializeComponent();
            dgv.KeyDown += dgv_KeyDown;
            dgv.CellFormatting += dgv_CellFormatting;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClubDatabase.GetSportsmens();
            _currentTable = CurrentTable.Sportsmen;
            dgv.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
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

        private void Btn4SportAdd_Click(object sender, EventArgs e)
        {
            var addForm = new Club_Start.Add.Data.AddSportsmenInBase();
            addForm.FormClosing += AddSportsmen_FormClosing;
            addForm.ShowDialog();
        }
        private void AddSportsmen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_currentTable == CurrentTable.Sportsmen)
            {
                dgv.DataSource = null;
                dgv.DataSource = ClubDatabase.GetSportsmens();
            }
        }

        private void BtnAddCoach_Click(object sender, EventArgs e)
        {
            AddCoach addCoach = new AddCoach();
            addCoach.FormClosing += AddCoach_FormClosing;
            addCoach.ShowDialog();
        }

        private void AddCoach_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (_currentTable == CurrentTable.Coaches)
            {
                dgv.DataSource = null;
                dgv.DataSource = ClubDatabase.GetCoaches();
            }
        }

        // Общий обработчик для всех DataGridView
        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    // Определяем, какую таблицу сейчас показываем
                    switch (_currentTable)
                    {
                        case CurrentTable.Sportsmen:
                            RowDeleteSportsmen(sender as DataGridView);
                            break;
                        case CurrentTable.Coaches:
                            RowDeleteCoach(sender as DataGridView);
                            break;
                        case CurrentTable.Attendances:
                            RowDeleteAttendance(sender as DataGridView);
                            break;
                        case CurrentTable.CoachStats:
                        case CurrentTable.PizdykActivity:
                        case CurrentTable.MissedAttendance:
                            MessageBox.Show("Это представление только для чтения", "Информация",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                    break;
            }
        }

        // Удаление спортсмена
        private void RowDeleteSportsmen(DataGridView dataGrid)
        {
            if (dataGrid.SelectedCells.Count == 0) return;

            int rowIndex = dataGrid.SelectedCells[0].RowIndex;
            var row = dataGrid.Rows[rowIndex];

            // Получаем объект Sportsmens из строки
            var sportsman = row.DataBoundItem as Sportsmens;
            if (sportsman != null)
            {
                DeleteData.RemoveSportsman(sportsman.Id);
                dataGrid.DataSource = ClubDatabase.GetSportsmens();
            }
        }

        // Удаление тренера
        private void RowDeleteCoach(DataGridView dataGrid)
        {
            if (dataGrid.SelectedCells.Count == 0) return;

            int rowIndex = dataGrid.SelectedCells[0].RowIndex;
            var row = dataGrid.Rows[rowIndex];

            var coach = row.DataBoundItem as Coaches;
            if (coach != null)
            {
                DeleteData.RemoveCoach(coach.Id);
                dataGrid.DataSource = ClubDatabase.GetCoaches();
            }
        }

        // Удаление записи о посещении
        private void RowDeleteAttendance(DataGridView dataGrid)
        {
            if (dataGrid.SelectedCells.Count == 0) return;

            int rowIndex = dataGrid.SelectedCells[0].RowIndex;
            var row = dataGrid.Rows[rowIndex];

            var attendance = row.DataBoundItem as Attendances;
            if (attendance != null)
            {
                DeleteData.RemoveAttendance(attendance.Id);
                dataGrid.DataSource = ClubDatabase.GetAttendances();
            }
        }

        private void Button6_Click(object sender, EventArgs e)
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
            if (_currentTable == CurrentTable.Attendances)
            {
                dgv.DataSource = null;
                dgv.DataSource = ClubDatabase.GetAttendances();
            }
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (_currentTable == CurrentTable.Sportsmen && dgv.Columns[e.ColumnIndex].Name == "Parent_Phone")
            {
                if (e.Value != null)
                {
                    string originalValue = e.Value.ToString();
                    string digits = "";
                    foreach (char c in originalValue)
                    {
                        if (char.IsDigit(c))
                            digits += c;
                    }

                    if (digits.Length >= 10)
                    {
                        if (digits.Length > 10)
                            digits = digits.Substring(digits.Length - 10);

                        e.Value = $"+7 ({digits.Substring(0, 3)}) {digits.Substring(3)}";
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dgv.Columns.Clear();
            dgv.DataSource = ClubDatabase.CoachStatus();
            _currentTable = CurrentTable.CoachStats;
            dgv.Focus();
        }
    }
}
