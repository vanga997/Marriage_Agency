using System;
using System.Collections.Generic;

namespace Marriage_Agency.Models
{
    public partial class ДополнительныеУслуги
    {
        public long КодУслуги { get; set; }
        public string Наименование { get; set; }
        public string Описание { get; set; }
        public double Цена { get; set; }

        public virtual Услуги Услуги { get; set; }
    }
}
