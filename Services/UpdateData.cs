using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_Start.Services
{
    public class UpdateData
    {
        public static void UpdateDataInBase(object data)
        {
            using var conn = new SQLiteConnection($"Data Source={ClubDatabase.ConnectionString}");
            conn.Open();

            if (data is Attendances attendance)
            {
                using var cmd = new SQLiteCommand(@"
                    UPDATE Attendances 
                    SET sportsmen_id = @sportsmen_id,
                        coach_id = @coach_id,
                        training_date = @training_date,
                        attended = @attended
                    WHERE at_id = @id", conn);

                cmd.Parameters.AddWithValue("@id", attendance.Id);
                cmd.Parameters.AddWithValue("@sportsmen_id", attendance.Sportsman_id?.Id ?? 0);
                cmd.Parameters.AddWithValue("@coach_id", attendance.Coach_id?.Id ?? 0);
                cmd.Parameters.AddWithValue("@training_date", attendance.Training_Date.ToString("yyyy-MM-dd"));

                // Преобразуем bool в строку 'Был'/'Не был'
                string attendedStr = attendance.Attended ? "Был" : "Не был";
                cmd.Parameters.AddWithValue("@attended", attendedStr);

                cmd.ExecuteNonQuery();
            }
        }
    }
}