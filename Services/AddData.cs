using Club_Start.Services;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Club_Start.Add_Classes
{
    public class AddData
    {
        public static Sportsmens AddSportsmens(Sportsmens sportsm)
        {
            string connectionString = $"Data Source={ClubDatabase.ConnectionString}";

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();


            using var cmd = new SQLiteCommand(
                "INSERT INTO Sportsmen (name, surname, last_name, birth, parent_phone) " +
                "VALUES (@name, @surname, @lastname, @birthdate, @parentphone)", conn);

            cmd.Parameters.AddWithValue("@name", sportsm.Name);
            cmd.Parameters.AddWithValue("@surname", sportsm.Surname);
            cmd.Parameters.AddWithValue("@lastname", sportsm.Last_Name);
            cmd.Parameters.AddWithValue("@birthdate", sportsm.Birth_Date);
            cmd.Parameters.AddWithValue("@parentphone", sportsm.Parent_Phone);

            cmd.ExecuteNonQuery();

            sportsm.Id = GetId();

            return sportsm;
        }

        public static Coaches AddCoaches(Coaches coach)
        {
            string connectionString = $"Data Source={ClubDatabase.ConnectionString}";

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand(
                "INSERT INTO Coaches (name, surname, last_name, specialization) " +
                "VALUES (@name, @surname, @lastname, @specialization)", conn);

            cmd.Parameters.AddWithValue("@name", coach.Name);
            cmd.Parameters.AddWithValue("@surname", coach.Surname);
            cmd.Parameters.AddWithValue("@lastname", coach.Last_Name);
            cmd.Parameters.AddWithValue("@specialization", coach.Specializtion);

            cmd.ExecuteNonQuery();

            coach.Id = GetId();

            return coach;
        }

        public static Attendances AddAttendances(Attendances attend)
        {
            string connectionString = $"Data Source={ClubDatabase.ConnectionString}";

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand(
                "INSERT INTO Attendances (sportsmen_id, coach_id, training_date, attended)" +
                "VALUES (@sportsmen_id, @coach_id, @training_date, @attended)", conn);

            cmd.Parameters.AddWithValue("@sportsmen_id", attend.Sportsman_id?.Id ?? 0);
            cmd.Parameters.AddWithValue("@coach_id", attend.Coach_id?.Id ?? 0);
            cmd.Parameters.AddWithValue("@training_date", attend.Training_Date);

            string attendedValue = attend.Attended ? "Был" : "Не был";
            cmd.Parameters.AddWithValue("@attended", attendedValue);

            cmd.ExecuteNonQuery();

            attend.Id = GetIdforAttend(conn);

            return attend;
        }
        public static int GetId()
        {
            using var conn = new SQLiteConnection($"Data Source={ClubDatabase.ConnectionString}");
            conn.Open();

            using var cmd = new SQLiteCommand("SELECT last_insert_rowid();", conn);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            return id;
        }

        public static int GetIdforAttend(SQLiteConnection conn)
        {
            using var cmd = new SQLiteCommand("SELECT last_insert_rowid();", conn);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            return id;
        }
    }
}
