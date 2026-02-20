using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace Club_Start
{
    public class Sportsmens
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Отчество")]
        public string Last_Name { get; set; }
        [DisplayName("День рождения")]
        public DateTime Birth_Date { get; set; }
        [DisplayName("Номер телефона родителя")]
        public string Parent_Phone { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }

}
