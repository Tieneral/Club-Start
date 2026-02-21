using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Club_Start.Models
{
    public class PizdykActivity
    {
        [Browsable(false)]
        public int SportsmanId { get; set; }
        [DisplayName("Имя спорстмена")]
        public string SportsmanName { get; set; }
        [DisplayName("Фамилия спорстмена")]
        public string SportsmanSurname { get; set; }
        [DisplayName("Дата рождения спортсмена")]
        public DateTime BirthDate { get; set; }
        [DisplayName("Все тренировки")]
        public int total_trainings { get; set; }
        [DisplayName("Пропущенный тренировки")]
        public int missed_count { get; set; }
        [DisplayName("Посещёные тренировки")]
        public int attended_count { get; set; }
        [DisplayName("Телефон родителя")]
        public string ParentPhone { get; set; }
    }
}
