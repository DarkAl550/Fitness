using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Database
{
    class DataManager : DatabaseManager
    {
        /*выборка записей*/
        public static SqlDataReader SelectValues(string table, string parametrs)
        {
            ConnOpen();
            SqlCommand command = new SqlCommand($"SELECT * FROM [{table}] {parametrs} ", SqlConnection());
            SqlDataReader read = command.ExecuteReader();
            return read;

        }
        /*Динамическое создание записей в таблице*/
        public static void InsertValuses(string table, string columns, string values, int id)
        {
            ConnOpen();
            string inserting = $"INSERT INTO [{table}]({columns}) VALUES(@id, {values})";
            SqlCommand command = new SqlCommand(inserting, SqlConnection());
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            command.ExecuteNonQuery();
            ConnClosed();
        }
        /*Динамическое обновление записей в таблице*/
        public static void UpdateValues(string table, string sets, string parametrs)
        {
            ConnOpen();
            string updating = $"UPDATE [{table}] SET {sets} WHERE {parametrs}";
            SqlCommand command = new SqlCommand(updating, SqlConnection());
            command.ExecuteNonQuery();
            ConnClosed();
        }
        /* Динамическое удаление записей из таблицы {table}*/
        public static void DeleteValues(string table, string parametrs)
        {
            ConnOpen();
            string deleting = $"DELETE FROM [{table}] WHERE {parametrs}";
            SqlCommand command = new SqlCommand(deleting, SqlConnection());
            command.ExecuteNonQuery();
            ConnClosed();
        }
        public static void CreateTables()
        {
            List<string> queres = new List<string>();
            string status = $"CREATE TABLE Status(Id INT PRIMARY KEY, Name TEXT);";
            queres.Add(status);
            string users = $"CREATE TABLE Users(Id INT PRIMARY KEY, Name Text, Birthdate DATE, Hieght FLOAT, Mass FLOAT, Status INTEGER REFEReNCES Status(Id));";
            queres.Add(users);
            string foodTable = $"CREATE TABLE Food(Id INT PRIMARY KEY, Callory FLOAT, Mass FLOAT, Name TEXT, Users INTEGER REFERENCES Users(Id));";
            queres.Add(foodTable);
            string exesizes = $"CREATE TABLE Exesize(Id INT PRIMARY KEY, Name TEXT, Counts INT, Repeats INT, StartDate DATE, EndDate DATE, Users INTEGER REFERENCES Users(Id), Food INTEGER REFERENCES Food(Id));";
            queres.Add(exesizes);
            
            ConnOpen();
            SqlCommand command = new SqlCommand(String.Join("",queres), SqlConnection());
            command.ExecuteNonQuery();
            ConnClosed();
        }
    }
}
