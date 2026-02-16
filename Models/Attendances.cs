using Club_Start.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Club_Start
{
    public class Attendances
    {
        public int Id { get; set; }

        [DisplayName("Спортсмен")]
        public Sportsmens Sportsman_id { get; set; }

        [DisplayName("Тренер")]
        public Coaches Coach_id { get; set; }

        [DisplayName("Дата тренировки")]
        public DateTime Training_Date { get; set; }

        [DisplayName("Посещаемость")]
        public bool Attended { get; set; }

        [DisplayName("Информация")]
        public string DisplayInfo => $"({Coach_id?.Surname}, {Sportsman_id?.Surname})";

        public static Sportsmens GetSportsmens(int id)
        {
            List<Sportsmens> sportsmens = ClubDatabase.GetSportsmens();
            return sportsmens.Find(s => s.Id == id);
        }

        public static Coaches GetCoaches(int id)
        {
            List<Coaches> coaches = ClubDatabase.GetCoaches();
            return coaches.Find(c => c.Id == id);
        }
    }
}
