using System;
using System.Collections.Generic;
using System.Text;

namespace Club_Start.Models
{
    public class PizdykActivity
    {
        public int SportsmanId { get; set; }
        public string SportsmanName { get; set; }
        public string SportsmanSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public int total_trainings { get; set; }
        public int missed_count { get; set; }
        public int attended_count { get; set; }
        public string ParentPhone { get; set; }
    }
}
