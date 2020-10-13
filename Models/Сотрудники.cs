using System;
using System.Collections.Generic;

namespace Marriage_Agency.Models
{
    public partial class Сотрудники
    {
        public Сотрудники()
        {
            Услуги = new HashSet<Услуги>();
        }

        public long КодСотрудника { get; set; }
        public string Фио { get; set; }
        public long Возраст { get; set; }
        public string Пол { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        public string ПаспортныеДанные { get; set; }
        public long КодДолжности { get; set; }

        public virtual Должности КодДолжностиNavigation { get; set; }
        public virtual ICollection<Услуги> Услуги { get; set; }
    }
}
