using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace Club_Start
{
    public class Sportsmen
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Отчество")]
        public string Last_Name { get; set; }
        [DisplayName("День рождения")]
        public DateTime Birth_Date { get; set; }
        [DisplayName("Номер телефона родителя")]
        public string Parent_Phone { get; set; }
        
        //public static void LoadSportsmen(DataGridView dgv, string dbPath = "..\\..\\..\\ClubStart.db")
        //{
        //    string connectionString = $"Data Source={dbPath};Version=3;";
        //    using (var connection = new SQLiteConnection(connectionString))
        //    {
        //        connection.Open();
        //        string query = "SELECT * FROM Sportsmen";
        //        using (var adapter = new SQLiteDataAdapter(query, connection))
        //        {
        //            DataTable dataTable = new DataTable();
        //            adapter.Fill(dataTable);
        //            dgv.DataSource = dataTable;
        //        }
        //    }
        //}
    }
}
