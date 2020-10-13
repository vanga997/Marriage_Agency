using System;
using System.Collections.Generic;

namespace Marriage_Agency.Models
{
    public partial class ЗнакиЗодиака
    {
        public ЗнакиЗодиака()
        {
            Клиенты = new HashSet<Клиенты>();
        }

        public long КодЗнака { get; set; }
        public string Наименование { get; set; }
        public string Описание { get; set; }

        public virtual ICollection<Клиенты> Клиенты { get; set; }
    }
}
