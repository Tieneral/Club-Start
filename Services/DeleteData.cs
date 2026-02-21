using System.Data;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_Start.Services
{
    class DeleteData
    {
        public static void RemoveAttendance(int id)
        {
            using var conn = new SQLiteConnection($"Data Source={ClubDatabase.ConnectionString}");
            conn.Open();

            using var cmd = new SQLiteCommand("DELETE FROM Attendances WHERE at_id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public static void RemoveSportsman(int id)
        {
            using var conn = new SQLiteConnection($"Data Source={ClubDatabase.ConnectionString}");
            conn.Open();

            using var cmd = new SQLiteCommand("DELETE FROM Sportsmen WHERE sp_id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public static void RemoveCoach(int id)
        {
            using var conn = new SQLiteConnection($"Data Source={ClubDatabase.ConnectionString}");
            conn.Open();

            using var cmd = new SQLiteCommand("DELETE FROM Coaches WHERE co_id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}