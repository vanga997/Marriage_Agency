using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marriage_Agency.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Должности",
                columns: table => new
                {
                    Код_должности = table.Column<int>(type: "INT", nullable: false),
                    Наименование_должности = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Оклад = table.Column<double>(type: "FLOAT", nullable: false),
                    Обязанности = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Требования = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Должности", x => x.Код_должности);
                });

            migrationBuilder.CreateTable(
                name: "Дополнительные_услуги",
                columns: table => new
                {
                    Код_услуги = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Описание = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Цена = table.Column<double>(type: "FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Дополнительные_услуги", x => x.Код_услуги);
                });

            migrationBuilder.CreateTable(
                name: "Знаки_зодиака",
                columns: table => new
                {
                    Код_знака = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Описание = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Знаки_зодиака", x => x.Код_знака);
                });

            migrationBuilder.CreateTable(
                name: "Национальности",
                columns: table => new
                {
                    Код_национальности = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Замечания = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Национальности", x => x.Код_национальности);
                });

            migrationBuilder.CreateTable(
                name: "Отношения",
                columns: table => new
                {
                    Код_отношения = table.Column<int>(type: "INT", nullable: false),
                    Наименование = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Описание = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Отношения", x => x.Код_отношения);
                });

            migrationBuilder.CreateTable(
                name: "Сотрудники",
                columns: table => new
                {
                    Код_сотрудника = table.Column<int>(type: "INT", nullable: false),
                    ФИО = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Возраст = table.Column<int>(type: "INT", nullable: false),
                    Пол = table.Column<string>(type: "CHAR(1)", nullable: false),
                    Адрес = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Телефон = table.Column<string>(type: "VARCHAR(11)", nullable: false),
                    Паспортные_данные = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Код_должности = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Сотрудники", x => x.Код_сотрудника);
                    table.ForeignKey(
                        name: "FK_Сотрудники_Должности_Код_должности",
                        column: x => x.Код_должности,
                        principalTable: "Должности",
                        principalColumn: "Код_должности",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Услуги",
                columns: table => new
                {
                    Код_услуги = table.Column<int>(type: "INT", nullable: false),
                    Дата = table.Column<byte[]>(type: "DateTime", nullable: false),
                    Стоимость = table.Column<double>(type: "FLOAT", nullable: false),
                    Код_сотрудника = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Услуги", x => x.Код_услуги);
                    table.ForeignKey(
                        name: "FK_Услуги_Сотрудники_Код_сотрудника",
                        column: x => x.Код_сотрудника,
                        principalTable: "Сотрудники",
                        principalColumn: "Код_сотрудника",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Услуги_Дополнительные_услуги_Код_услуги",
                        column: x => x.Код_услуги,
                        principalTable: "Дополнительные_услуги",
                        principalColumn: "Код_услуги",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Клиенты",
                columns: table => new
                {
                    Код_клиента = table.Column<int>(type: "INT", nullable: false),
                    ФИО = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Пол = table.Column<string>(type: "CHAR(1)", nullable: false),
                    Дата_рождения = table.Column<byte[]>(type: "DateTime", nullable: false),
                    _Возраст = table.Column<int>(type: "INT", nullable: false),
                    Рост = table.Column<int>(type: "INT", nullable: false),
                    Вес = table.Column<int>(type: "INT", nullable: false),
                    Количество_детей = table.Column<int>(type: "INT", nullable: false),
                    Семейное_положение = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Вредные_привычки = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Хобби = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Описание = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Адрес = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Телефон = table.Column<string>(type: "VARCHAR(11)", nullable: false),
                    Паспортные_данные = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Информация_о_партнёре = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Код_услуги_3 = table.Column<int>(type: "INT", nullable: false),
                    Код_услуги_1 = table.Column<int>(type: "INT", nullable: false),
                    Код_услуги_2 = table.Column<int>(type: "INT", nullable: false),
                    Код_национальности = table.Column<int>(type: "INT", nullable: false),
                    Код_отношения = table.Column<int>(type: "INT", nullable: false),
                    Код_знака = table.Column<int>(type: "INT", nullable: false),
                    Код_услуги = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Клиенты", x => x.Код_клиента);
                    table.ForeignKey(
                        name: "FK_Клиенты_Знаки_зодиака_Код_знака",
                        column: x => x.Код_знака,
                        principalTable: "Знаки_зодиака",
                        principalColumn: "Код_знака",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Клиенты_Национальности_Код_национальности",
                        column: x => x.Код_национальности,
                        principalTable: "Национальности",
                        principalColumn: "Код_национальности",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Клиенты_Отношения_Код_отношения",
                        column: x => x.Код_отношения,
                        principalTable: "Отношения",
                        principalColumn: "Код_отношения",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Клиенты_Услуги_Код_услуги",
                        column: x => x.Код_услуги,
                        principalTable: "Услуги",
                        principalColumn: "Код_услуги",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Клиенты_Код_знака",
                table: "Клиенты",
                column: "Код_знака");

            migrationBuilder.CreateIndex(
                name: "IX_Клиенты_Код_национальности",
                table: "Клиенты",
                column: "Код_национальности");

            migrationBuilder.CreateIndex(
                name: "IX_Клиенты_Код_отношения",
                table: "Клиенты",
                column: "Код_отношения");

            migrationBuilder.CreateIndex(
                name: "IX_Клиенты_Код_услуги",
                table: "Клиенты",
                column: "Код_услуги");

            migrationBuilder.CreateIndex(
                name: "IX_Сотрудники_Код_должности",
                table: "Сотрудники",
                column: "Код_должности");

            migrationBuilder.CreateIndex(
                name: "IX_Услуги_Код_сотрудника",
                table: "Услуги",
                column: "Код_сотрудника");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Клиенты");

            migrationBuilder.DropTable(
                name: "Знаки_зодиака");

            migrationBuilder.DropTable(
                name: "Национальности");

            migrationBuilder.DropTable(
                name: "Отношения");

            migrationBuilder.DropTable(
                name: "Услуги");

            migrationBuilder.DropTable(
                name: "Сотрудники");

            migrationBuilder.DropTable(
                name: "Дополнительные_услуги");

            migrationBuilder.DropTable(
                name: "Должности");
        }
    }
}
