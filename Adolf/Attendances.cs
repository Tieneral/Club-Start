using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Club_Start
{
    internal class Attendances
    {
        public int Id { get; set; }
        [DisplayName("ID Спортсмена")]
        public int Sportsman_id { get; set; }
        [DisplayName("ID Тренера")]
        public int Coach_id { get; set; }
        [DisplayName("дата тренеровки")]
        public DateTime Training_Date { get; set; }
        [DisplayName("Посещаемость спортсмена")]
        public bool Attended { get; set; }
    }
}
