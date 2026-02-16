using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

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
                    Parent_Phone = reader.GetInt32(5)
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
                attendances.Add(new Attendances
                {
                    Id = reader.GetInt32(0),
                    Sportsman_id = Attendances.GetSportsmens(reader.GetInt32(1)),
                    Coach_id = Attendances.GetCoaches(reader.GetInt32(2)),
                    Training_Date = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                    Attended = reader.GetBoolean(4)
                });
            }
            return attendances;
        }
    }
}