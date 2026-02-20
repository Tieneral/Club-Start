using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Club_Start
{
    public class Coaches
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Отчество")]
        public string Last_Name { get; set; }
        [DisplayName("Специализация")]
        public string Specializtion { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
