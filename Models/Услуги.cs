using System;
using System.Collections.Generic;

namespace Marriage_Agency.Models
{
    public partial class Услуги
    {
        public Услуги()
        {
            Клиенты = new HashSet<Клиенты>();
        }

        public DateTime Дата { get; set; }
        public double Стоимость { get; set; }
        public long КодУслуги { get; set; }
        public long КодСотрудника { get; set; }

        public virtual Сотрудники КодСотрудникаNavigation { get; set; }
        public virtual ДополнительныеУслуги КодУслугиNavigation { get; set; }
        public virtual ICollection<Клиенты> Клиенты { get; set; }
    }
}
