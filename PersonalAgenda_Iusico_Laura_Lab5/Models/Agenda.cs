using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace PersonalAgenda_Iusico_Laura_Lab5.Models
{
    public class Agenda
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
