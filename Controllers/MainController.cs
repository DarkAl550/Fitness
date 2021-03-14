using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Database;
namespace FitnessApp.Controllers
{
    class MainController
    {
        public static void ChangeDataPath(string pcName, string dbName)
        {
            if(InitialStartController.checkServerPath() != null)
            {
                InitialStartController.createServerLogFile(pcName, dbName, true);
            }
        }
        public static void deleteExesize(string name)
        {
            Database.DataManager.DeleteValues("Exesize", $"Name LIKE '{name}'");
        }
        public static void deleteFood(string name)
        {
            Database.DataManager.DeleteValues("Food", $"Name LIKE '{name}'");
        }
        public static void InsertExesize(string name, string startDate, string endDate, string counts, string repeats, string user, string food)
        {
            List<string> columns = new List<string>
            {
                "Name",
                "StartDate",
                "EndDate",
                "Counts",
                "Repeats",
                "Users",
                "Food"
            };
            List<string> values = new List<string>
            {
                name,
                startDate,
                endDate,
                counts,
                repeats,
                user,
                food
            };
            Random r = new Random();
            Database.DataManager.InsertValuses("Exesize", String.Join(",", columns), String.Join(",", values), r.Next(int.MaxValue));
        }
        public static string GenerateRecomends(string mass, string hieght)
        {
            try
            {
                if (double.Parse(mass) > 50 && double.Parse(hieght) > 180)
                {
                    return "";
                }
                else if (double.Parse(mass) < 50 && double.Parse(hieght) > 180)
                {
                    return "";
                }
                else if (double.Parse(mass) > 50 && double.Parse(hieght) < 180)
                {
                    return "";
                }
                else if (double.Parse(mass) >= 100 && double.Parse(hieght) >= 190)
                {
                    return "";
                }
                else
                {
                    return null;
                }
            }
            catch(Exception e)
            {
                return null;
            }
           
        }
    }
    
}
