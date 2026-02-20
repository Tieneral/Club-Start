using Club_Start.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Club_Start.Services
{
    public class ClubDatabase
    {
        public static readonly string ConnectionString = Path.Combine(AppContext.BaseDirectory, @"..\..\..\ClubStart.db");

        public static List<Sportsmens> GetSportsmens()
        {
            using var conn = new SQLiteConnection($"Data Source={ConnectionString}");
            conn.Open();

            List<Sportsmens> sportsmens = new();
            using var cmd = new SQLiteCommand("SELECT * FROM Sportsmen", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sportsmens.Add(new Sportsmens
                {
                    Id = reader.GetInt32(0),
                    Name = reader.IsDBNull(1) ? "" : reader.GetString(1),
                    Surname = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    Last_Name = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    Birth_Date = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4),
                    Parent_Phone = reader.GetString(5)
                });
            }

            return sportsmens;
        }

        public static List<Coaches> GetCoaches()
        {
            using var conn = new SQLiteConnection($"Data Source={ConnectionString}");
            conn.Open();

            List<Coaches> coaches = new();
            using var cmd = new SQLiteCommand("SELECT * FROM Coaches", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                coaches.Add(new Coaches
                {
                    Id = reader.GetInt32(0),
                    Name = reader.IsDBNull(1) ? "" : reader.GetString(1),
                    Surname = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    Last_Name = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    Specializtion = reader.IsDBNull(4) ? "" : reader.GetString(4)
                });
            }
            return coaches;
        }

        public static List<Attendances> GetAttendances()
        {
            using var conn = new SQLiteConnection($"Data Source={ConnectionString}");
            conn.Open();

            List<Attendances> attendances = new();
            using var cmd = new SQLiteCommand("SELECT * FROM Attendances", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string attendedStr = reader.IsDBNull(4) ? "" : reader.GetString(4).Trim().ToLower();

                // Конвертируем в bool (true если "был", false если "не был")
                bool attended = attendedStr == "был" || attendedStr == "true" || attendedStr == "1";

                attendances.Add(new Attendances
                {
                    Id = reader.GetInt32(0),
                    Sportsman_id = Attendances.GetSportsmens(reader.GetInt32(1)),
                    Coach_id = Attendances.GetCoaches(reader.GetInt32(2)),
                    Training_Date = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                    Attended = attended
                });
            }
            return attendances;
        }

        public static List<MissedAttendance> GetMissedAttendances(DateTime startDate, DateTime endDate)
        {
            var attendanceList = new List<MissedAttendance>();

            using var conn = new SQLiteConnection($"Data Source={ConnectionString}");
            conn.Open();

            string query = @"
                SELECT 
                    s.sp_id,
                    s.name,
                    s.surname,
                    s.last_name,
                    s.birth,
                    s.parent_phone,
                    a.training_date,
                    a.coach_id,
                    c.name AS coach_name,
                    c.surname AS coach_surname
                FROM Sportsmen s
                JOIN Attendances a ON s.sp_id = a.sportsmen_id
                JOIN Coaches c ON a.coach_id = c.co_id
                WHERE a.attended = 'Не был'
                AND a.training_date BETWEEN @startDate AND @endDate
                ORDER BY a.training_date DESC";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd"));

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                attendanceList.Add(new MissedAttendance
                {
                    SportsmanId = reader.GetInt32(0),
                    SportsmanName = reader.IsDBNull(1) ? "" : reader.GetString(1),
                    SportsmanSurname = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    SportsmanLastName = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    BirthDate = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4),
                    ParentPhone = reader.IsDBNull(5) ? "" : reader.GetString(5),
                    TrainingDate = reader.GetDateTime(6),
                    CoachId = reader.GetInt32(7),
                    CoachName = reader.IsDBNull(8) ? "" : reader.GetString(8),
                    CoachSurname = reader.IsDBNull(9) ? "" : reader.GetString(9)
                });
            }

            return attendanceList;
        }

        public static List<PizdykActivity> PizdykActivity()
        {
            var pyzdykList = new List<PizdykActivity>();

            using var conn = new SQLiteConnection($"Data Source={ConnectionString}");
            conn.Open();

            string query = @"
                SELECT 
                    s.sp_id,
                    s.name,
                    s.surname,
                    s.last_name,
                    s.birth,
                    COUNT(a.at_id) AS total_trainings,
                    SUM(CASE WHEN a.attended = 'Не был' THEN 1 ELSE 0 END) AS missed_count,
                    SUM(CASE WHEN a.attended = 'Был' THEN 1 ELSE 0 END) AS attended_count,
                    s.parent_phone
                FROM Sportsmen s
                LEFT JOIN Attendances a ON s.sp_id = a.sportsmen_id
                GROUP BY s.sp_id, s.name, s.surname, s.last_name, s.birth, s.parent_phone
                ORDER BY attended_count DESC";

            using var cmd = new SQLiteCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pyzdykList.Add(new PizdykActivity
                {
                    SportsmanId = reader.GetInt32(0),
                    SportsmanName = reader.IsDBNull(1) ? "" : reader.GetString(1),
                    SportsmanSurname = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    BirthDate = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4),
                    total_trainings = reader.GetInt32(5),
                    missed_count = reader.GetInt32(6),
                    attended_count = reader.GetInt32(7),
                    ParentPhone = reader.IsDBNull(8) ? "" : reader.GetString(8)
                });
            }

            return pyzdykList;
        }
    }
}