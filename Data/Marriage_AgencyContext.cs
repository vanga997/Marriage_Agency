using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Marriage_Agency.Models;

namespace Marriage_Agency.Data
{
    public partial class Marriage_AgencyContext : DbContext
    {
        public Marriage_AgencyContext()
        {
        }

        public Marriage_AgencyContext(DbContextOptions<Marriage_AgencyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Должности> Должности { get; set; }
        public virtual DbSet<ДополнительныеУслуги> ДополнительныеУслуги { get; set; }
        public virtual DbSet<ЗнакиЗодиака> ЗнакиЗодиака { get; set; }
        public virtual DbSet<Клиенты> Клиенты { get; set; }
        public virtual DbSet<Национальности> Национальности { get; set; }
        public virtual DbSet<Отношения> Отношения { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public virtual DbSet<Услуги> Услуги { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //    optionsBuilder.UseSqlite("Data Source=D:\\Учёба\\2 курс\\Marriage Agency\\Marriage_Agency.db");
                optionsBuilder.UseSqlServer("Data Source=SSMLNSK;Initial Catalog=Marriage_Agency;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Должности>(entity =>
            {
                entity.HasKey(e => e.КодДолжности);

                entity.Property(e => e.КодДолжности)
                    .HasColumnName("Код_должности")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.НаименованиеДолжности)
                    .IsRequired()
                    .HasColumnName("Наименование_должности")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Обязанности)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.Оклад).HasColumnType("FLOAT");

                entity.Property(e => e.Требования)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");
            });

            modelBuilder.Entity<ДополнительныеУслуги>(entity =>
            {
                entity.HasKey(e => e.КодУслуги);

                entity.ToTable("Дополнительные_услуги");

                entity.Property(e => e.КодУслуги)
                    .HasColumnName("Код_услуги")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Описание)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.Цена).HasColumnType("FLOAT");
            });

            modelBuilder.Entity<ЗнакиЗодиака>(entity =>
            {
                entity.HasKey(e => e.КодЗнака);

                entity.ToTable("Знаки_зодиака");

                entity.Property(e => e.КодЗнака)
                    .HasColumnName("Код_знака")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Описание)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");
            });

            modelBuilder.Entity<Клиенты>(entity =>
            {
                entity.HasKey(e => e.КодКлиента);

                entity.Property(e => e.КодКлиента)
                    .HasColumnName("Код_клиента")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Адрес)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.Вес).HasColumnType("INT");

                entity.Property(e => e.Возраст)
                    .HasColumnName("_Возраст")
                    .HasColumnType("INT");

                entity.Property(e => e.ВредныеПривычки)
                    .IsRequired()
                    .HasColumnName("Вредные_привычки")
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.ДатаРождения)
                    .IsRequired()
                    .HasColumnName("Дата_рождения")
                    .HasColumnType("DataTime");

                entity.Property(e => e.ИнформацияОПартнёре)
                    .IsRequired()
                    .HasColumnName("Информация_о_партнёре")
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.КодЗнака)
                    .HasColumnName("Код_знака")
                    .HasColumnType("INT");

                entity.Property(e => e.КодНациональности)
                    .HasColumnName("Код_национальности")
                    .HasColumnType("INT");

                entity.Property(e => e.КодОтношения)
                    .HasColumnName("Код_отношения")
                    .HasColumnType("INT");

                entity.Property(e => e.КодУслуги)
                    .HasColumnName("Код_услуги")
                    .HasColumnType("INT");

                entity.Property(e => e.КодУслуги1)
                    .HasColumnName("Код_услуги_1")
                    .HasColumnType("INT");

                entity.Property(e => e.КодУслуги2)
                    .HasColumnName("Код_услуги_2")
                    .HasColumnType("INT");

                entity.Property(e => e.КодУслуги3)
                    .HasColumnName("Код_услуги_3")
                    .HasColumnType("INT");

                entity.Property(e => e.КоличествоДетей)
                    .HasColumnName("Количество_детей")
                    .HasColumnType("INT");

                entity.Property(e => e.Описание)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");

                entity.Property(e => e.ПаспортныеДанные)
                    .IsRequired()
                    .HasColumnName("Паспортные_данные")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Пол)
                    .IsRequired()
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Рост).HasColumnType("INT");

                entity.Property(e => e.СемейноеПоложение)
                    .IsRequired()
                    .HasColumnName("Семейное_положение")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Телефон)
                    .IsRequired()
                    .HasColumnType("VARCHAR(11)");

                entity.Property(e => e.Фио)
                    .IsRequired()
                    .HasColumnName("ФИО")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Хобби)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");

                entity.HasOne(d => d.КодЗнакаNavigation)
                    .WithMany(p => p.Клиенты)
                    .HasForeignKey(d => d.КодЗнака)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодНациональностиNavigation)
                    .WithMany(p => p.Клиенты)
                    .HasForeignKey(d => d.КодНациональности)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодОтношенияNavigation)
                    .WithMany(p => p.Клиенты)
                    .HasForeignKey(d => d.КодОтношения)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодУслугиNavigation)
                    .WithMany(p => p.Клиенты)
                    .HasForeignKey(d => d.КодУслуги)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Национальности>(entity =>
            {
                entity.HasKey(e => e.КодНациональности);

                entity.Property(e => e.КодНациональности)
                    .HasColumnName("Код_национальности")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Замечания)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)");
            });

            modelBuilder.Entity<Отношения>(entity =>
            {
                entity.HasKey(e => e.КодОтношения);

                entity.Property(e => e.КодОтношения)
                    .HasColumnName("Код_отношения")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Наименование)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Описание)
                    .IsRequired()
                    .HasColumnType("VARCHAR(100)");
            });

            modelBuilder.Entity<Сотрудники>(entity =>
            {
                entity.HasKey(e => e.КодСотрудника);

                entity.Property(e => e.КодСотрудника)
                    .HasColumnName("Код_сотрудника")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Адрес)
                    .IsRequired()
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Возраст).HasColumnType("INT");

                entity.Property(e => e.КодДолжности)
                    .HasColumnName("Код_должности")
                    .HasColumnType("INT");

                entity.Property(e => e.ПаспортныеДанные)
                    .IsRequired()
                    .HasColumnName("Паспортные_данные")
                    .HasColumnType("VARCHAR(50)");

                entity.Property(e => e.Пол)
                    .IsRequired()
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Телефон)
                    .IsRequired()
                    .HasColumnType("VARCHAR(11)");

                entity.Property(e => e.Фио)
                    .IsRequired()
                    .HasColumnName("ФИО")
                    .HasColumnType("VARCHAR(50)");

                entity.HasOne(d => d.КодДолжностиNavigation)
                    .WithMany(p => p.Сотрудники)
                    .HasForeignKey(d => d.КодДолжности)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Услуги>(entity =>
            {
                entity.HasKey(e => e.КодУслуги);

                entity.Property(e => e.КодУслуги)
                    .HasColumnName("Код_услуги")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Дата)
                    .IsRequired()
                    .HasColumnType("DataTime");

                entity.Property(e => e.КодСотрудника)
                    .HasColumnName("Код_сотрудника")
                    .HasColumnType("INT");

                entity.Property(e => e.Стоимость).HasColumnType("FLOAT");

                entity.HasOne(d => d.КодСотрудникаNavigation)
                    .WithMany(p => p.Услуги)
                    .HasForeignKey(d => d.КодСотрудника)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодУслугиNavigation)
                    .WithOne(p => p.Услуги)
                    .HasForeignKey<Услуги>(d => d.КодУслуги)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
