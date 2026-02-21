using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Club_Start.Models
{
    public class CoachStats
    {
        [Browsable(false)]
        public int CoachID { get; set; }

        [DisplayName("ФИО тренера")]
        public string FullName { get; set; }

        [DisplayName("Специализация")]
        public string Specialization { get; set; }

        [DisplayName("Всего тренировок")]
        public int TotalAttend { get; set; }

        [DisplayName("Посещено")]
        public int TotalPossibleTraining { get; set; }

        [DisplayName("Пропущено")]
        public int AttendMisses { get; set; }

        [DisplayName("Процент посещений")]
        public double AttendPerc { get; set; } // Изменено с bool на double

    }
}