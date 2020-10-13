using System;
using System.Collections.Generic;

namespace Marriage_Agency.Models
{
    public partial class Отношения
    {
        public Отношения()
        {
            Клиенты = new HashSet<Клиенты>();
        }

        public long КодОтношения { get; set; }
        public string Наименование { get; set; }
        public string Описание { get; set; }

        public virtual ICollection<Клиенты> Клиенты { get; set; }
    }
}
