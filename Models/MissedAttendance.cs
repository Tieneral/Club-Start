using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Start.Models
{
    public class MissedAttendance
    {
        public int SportsmanId { get; set; }
        public string SportsmanName { get; set; }
        public string SportsmanSurname { get; set; }
        public string SportsmanLastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string ParentPhone { get; set; }
        public DateTime TrainingDate { get; set; }
        public int CoachId { get; set; }
        public string CoachName { get; set; }
        public string CoachSurname { get; set; }
    }
}
