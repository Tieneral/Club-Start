using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Club_Start.Models
{
    public class MissedAttendance
    {
        [Browsable(false)]
        public int SportsmanId { get; set; }
        [DisplayName("Имя спорстмена")]
        public string SportsmanName { get; set; }
        [DisplayName("Фамилия спорстмена")]
        public string SportsmanSurname { get; set; }
        [DisplayName("Отчество спорстмена")]
        public string SportsmanLastName { get; set; }
        [DisplayName("Дата рождения спортсмена")]
        public DateTime BirthDate { get; set; }
        [DisplayName("Телефон родителя")]
        public string ParentPhone { get; set; }
        [DisplayName("Дата тренировки")]
        public DateTime TrainingDate { get; set; }
        [Browsable(false)]
        public int CoachId { get; set; }
        [DisplayName("Имя тренера")]
        public string CoachName { get; set; }
        [DisplayName("Фамилия тренера")]
        public string CoachSurname { get; set; }
    }
}
