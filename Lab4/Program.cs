using System;
using System.Collections.Generic;

namespace DependencyInjection
{
    class Program
    {
        /// <summary>
        /// точка входу в программу 
        /// </summary>
        /// <param name="args">аргументы командной строки </param>
        static void Main(string[] args)
        {
            try
            {
                DBMS database = null;
                Console.WriteLine("Select DBMS: ");
                Console.WriteLine("1 - Oracle");
                Console.WriteLine("2 - MySQL");
                var dbmsName = Console.ReadLine();
                if (int.TryParse(dbmsName, out int dbms))
                {
                    switch (dbms)
                    {
                        case 1:
                            database = new DBMS(new Oracle());
                            break;
                        case 2:
                            database = new DBMS(new MySQL());
                            break;
                        default:
                            throw new ArgumentException("Unknown DBMS", nameof(dbms));
                    }
                }
                Console.WriteLine("Select action: ");
                Console.WriteLine("1 - CreateDatabase");
                Console.WriteLine("2 - CreateTable");
                Console.WriteLine("3 - Select");
                Console.WriteLine("4 - InsertRow");
                Console.WriteLine("5 - UpdateRow");
                Console.WriteLine("6 - DeleteRow");
                Console.WriteLine("7 - AlterTable");
                Console.WriteLine("8 - DropTable");
                Console.WriteLine("9 - DropDatabase");
                Console.WriteLine("10 - Commit");
                var dbmsAction = Console.ReadLine();
                if (int.TryParse(dbmsAction, out int action))
                {
                    switch (action)
                    {
                        case 1:
                            database.controller.CreateDatabase();
                            break;
                        case 2:
                            database.controller.CreateTable();
                            break;
                        case 3:
                            database.controller.Select();
                            break;
                        case 4:
                            database.controller.InsertRow();
                            break;
                        case 5:
                            database.controller.UpdateRow();
                            break;
                        case 6:
                            database.controller.DeleteRow();
                            break;
                        case 7:
                            database.controller.AlterTable();
                            break;
                        case 8:
                            database.controller.DropTable();
                            break;
                        case 9:
                            database.controller.DropDatabase();
                            break;
                        case 10:
                            database.controller.Commit();
                            break;
                        default:
                            throw new ArgumentException("Unknown action", nameof(action));
                    }
                }
            }
            catch
            {
                Console.WriteLine("Not correct values");
            }
            
        }
    }
    /// <summary>
    /// Основной класс СУБД
    /// </summary>
    public class DBMS
    {
        /// <summary>
        /// контроллер 
        /// </summary>
        public DBMScontroller controller;
        /// <summary>
        /// Создать экземпляр СУБД (паттерн - внедрение зависимостей через конструктор 
        /// </summary>
        /// <param name="_controller">конкретная СУБД</param>
        public DBMS(DBMScontroller _controller)
        {
            controller = _controller;
        }
    }
    /// <summary>
    /// класс контроллер, выполняющий стандартные действия 
    /// </summary>
    public interface DBMScontroller
    {
        /// <summary>
        /// Создать базу данных
        /// </summary>
        void CreateDatabase()
        {

        }
        /// <summary>
        /// создать таблицу 
        /// </summary>
        void CreateTable()
        {

        }
        /// <summary>
        /// выбрать данные 
        /// </summary>
        void Select()
        {

        }
        /// <summary>
        /// вставить строчку 
        /// </summary>
        void InsertRow()
        {

        }
        /// <summary>
        /// обновить строчку 
        /// </summary>
        void UpdateRow()
        {

        }
        /// <summary>
        /// удалить строчку 
        /// </summary>
        void DeleteRow()
        {

        }
        /// <summary>
        /// изменить определение таблицы 
        /// </summary>
        void AlterTable()
        {

        }
        /// <summary>
        /// удалить таблицу 
        /// </summary>
        void DropTable()
        {

        }
        /// <summary>
        /// удалить базу данных 
        /// </summary>
        void DropDatabase()
        {

        }
        /// <summary>
        /// подтвердить транзакцию
        /// </summary>
        void Commit()
        {

        }
    }
    /// <summary>
    /// Действия, выполняемые СУБД Oracle 
    /// </summary>
    public class Oracle: DBMScontroller
    {
        /// <summary>
        /// создать базу данных Oracle 
        /// </summary>
        public void CreateDatabase()
        {
            Console.WriteLine("Oracle CreateDatabase");
        }
        /// <summary>
        /// Создать Таблицу Oracle 
        /// </summary>
        public void CreateTable()
        {
            Console.WriteLine("Oracle CreateTable");
        }
        /// <summary>
        /// Выбрать данные Oracle 
        /// </summary>
        public void Select()
        {
            Console.WriteLine("Oracle Select");
        }
        /// <summary>
        /// Вставить строку Oracle 
        /// </summary>
        public void InsertRow()
        {
            Console.WriteLine("Oracle InsertRow");
        }
        /// <summary>
        /// Обновить строку Oracle 
        /// </summary>

        public void UpdateRow()
        {
            Console.WriteLine("Oracle UpdateRow");
        }
        /// <summary>
        /// Удалить строку Oracle 
        /// </summary>
        public void DeleteRow()
        {
            Console.WriteLine("Oracle DeleteRow");
        }
        /// <summary>
        /// Изменить определение таблицы Oracle 
        /// </summary>
        public void AlterTable()
        {
            Console.WriteLine("Oracle AlterTable");
        }
        /// <summary>
        /// Удалить таблицу Oracle 
        /// </summary>
        public void DropTable()
        {
            Console.WriteLine("Oracle DropTable");
        }
        /// <summary>
        /// удалить базу данных Oracle 
        /// </summary>
        public void DropDatabase()
        {
            Console.WriteLine("Oracle DropDatabase");
        }
        /// <summary>
        /// подтвердить транзакцию Oracle 
        /// </summary>
        public void Commit()
        {
            Console.WriteLine("Oracle Commit");
        }
    }
    /// <summary>
    /// Действия, выполняемые СУБД MySQL
    /// </summary>
    public class MySQL : DBMScontroller
    {
        /// <summary>
        /// создать базу данных MySQL
        /// </summary>
        public void CreateDatabase()
        {
            Console.WriteLine("MySQL CreateDatabase");
        }
        /// <summary>
        /// Создать таблицу MySQL
        /// </summary>

        public void CreateTable()
        {
            Console.WriteLine("MySQL CreateTable");
        }
        /// <summary>
        /// Выбрать данные MySQL
        /// </summary>
        public void Select()
        {
            Console.WriteLine("MySQL Select");
        }
        /// <summary>
        /// Вставить строку MySQL
        /// </summary>
        public void InsertRow()
        {
            Console.WriteLine("MySQL InsertRow");
        }
        /// <summary>
        /// Обновить строку MySQL
        /// </summary>
        public void UpdateRow()
        {
            Console.WriteLine("MySQL UpdateRow");
        }
        /// <summary>
        /// удалить строку MySQL
        /// </summary>
        public void DeleteRow()
        {
            Console.WriteLine("MySQL DeleteRow");
        }
        /// <summary>
        /// изменить определение таблицы MySQL
        /// </summary>
        public void AlterTable()
        {
            Console.WriteLine("MySQL AlterTable");
        }
        /// <summary>
        /// удалить таблицу MySQL
        /// </summary>
        public void DropTable()
        {
            Console.WriteLine("MySQL DropTable");
        }
        /// <summary>
        /// удалить базу данных MySQL
        /// </summary>
        public void DropDatabase()
        {
            Console.WriteLine("MySQL DropDatabase");
        }
        /// <summary>
        /// подтвердить транзакцию MySQL
        /// </summary>
        public void Commit()
        {
            Console.WriteLine("MySQL Commit");
        }
    }
}
