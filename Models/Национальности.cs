using System;
using System.Collections.Generic;

namespace Marriage_Agency.Models
{
    public partial class Национальности
    {
        public Национальности()
        {
            Клиенты = new HashSet<Клиенты>();
        }

        public long КодНациональности { get; set; }
        public string Наименование { get; set; }
        public string Замечания { get; set; }

        public virtual ICollection<Клиенты> Клиенты { get; set; }
    }
}
