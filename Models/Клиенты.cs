﻿using System;
using System.Collections.Generic;

namespace Marriage_Agency.Models
{
    public partial class Клиенты
    {
        public long КодКлиента { get; set; }
        public string Фио { get; set; }
        public string Пол { get; set; }
        public byte[] ДатаРождения { get; set; }
        public long Возраст { get; set; }
        public long Рост { get; set; }
        public long Вес { get; set; }
        public long КоличествоДетей { get; set; }
        public string СемейноеПоложение { get; set; }
        public string ВредныеПривычки { get; set; }
        public string Хобби { get; set; }
        public string Описание { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        public string ПаспортныеДанные { get; set; }
        public string ИнформацияОПартнёре { get; set; }
        public long КодУслуги3 { get; set; }
        public long КодУслуги1 { get; set; }
        public long КодУслуги2 { get; set; }
        public long КодНациональности { get; set; }
        public long КодОтношения { get; set; }
        public long КодЗнака { get; set; }
        public long КодУслуги { get; set; }

        public virtual ЗнакиЗодиака КодЗнакаNavigation { get; set; }
        public virtual Национальности КодНациональностиNavigation { get; set; }
        public virtual Отношения КодОтношенияNavigation { get; set; }
        public virtual Услуги КодУслугиNavigation { get; set; }
    }
}
