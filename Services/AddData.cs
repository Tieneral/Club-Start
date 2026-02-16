using Club_Start.Services;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Club_Start.Add_Classes
{
    public class AddData
    {
        public static int GetId()
        {
            using var conn = new SQLiteConnection($"Data Source={ClubDatabase.ConnectionString}");
            conn.Open();

            using var cmd = new SQLiteCommand("SELECT last_insert_rowid();", conn);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            return id;
        }
    }
}
