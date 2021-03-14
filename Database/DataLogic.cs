using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Database
{
    class DataLogic
    {
        public static List<DataObjects.Users> getUsers(string parameters)
        {
            List<DataObjects.Users> users = new List<DataObjects.Users>();
            SqlDataReader getLists = DataManager.SelectValues("Users", parameters);

            while (getLists.Read())
            {
                DataObjects.Users user = new DataObjects.Users();
                user.Id = getLists["Id"].ToString();
                user.Name = getLists["Name"].ToString();
                user.BirthDate = getLists["Birthdate"].ToString();
                user.Hieght = getLists["Hieght"].ToString();
                user.StatusId = getLists["Status"].ToString();
                user.Mass = getLists["Mass"].ToString();
                users.Add(user);
            }
            getLists.Close();
            return users;
        }
        public static List<DataObjects.Status> getStatus(string parameters)
        {
            List<DataObjects.Status> statuses = new List<DataObjects.Status>();
            SqlDataReader getLists = DataManager.SelectValues("Status", parameters);

            while (getLists.Read())
            {
                DataObjects.Status status = new DataObjects.Status();
                status.Id = getLists["Id"].ToString();
                status.Name = getLists["Name"].ToString();
                statuses.Add(status);
            }
            getLists.Close();
            return statuses;
        }
        public static List<DataObjects.Food> getFood(string parameters)
        {
            List<DataObjects.Food> foods = new List<DataObjects.Food>();
            SqlDataReader getLists = DataManager.SelectValues("Food", parameters);

            while (getLists.Read())
            {
                DataObjects.Food food = new DataObjects.Food();
                food.Id = getLists["Id"].ToString();
                food.Name = getLists["Name"].ToString();
                food.Callory = getLists["Callory"].ToString();
                food.Mass = getLists["Mass"].ToString();
                food.UserId = getLists["Users"].ToString();
                foods.Add(food);
            }
            getLists.Close();
            return foods;
        }
        public static List<DataObjects.Exesize> getExesize(string parameters)
        {
            List<DataObjects.Exesize> exesizes = new List<DataObjects.Exesize>();
            SqlDataReader getLists = DataManager.SelectValues("Food", parameters);

            while (getLists.Read())
            {
                DataObjects.Exesize exesize = new DataObjects.Exesize();
                exesize.Id = getLists["Id"].ToString();
                exesize.Name = getLists["Name"].ToString();
                exesize.StartDate = getLists["StartDate"].ToString();
                exesize.EndDate = getLists["EndDate"].ToString();
                exesize.UserId = getLists["Users"].ToString();
                exesize.Counts = getLists["Counts"].ToString();
                exesize.RecomendedFood = getLists["Food"].ToString();
                exesize.Repeats = getLists["Repeats"].ToString();
                exesizes.Add(exesize);
            }
            getLists.Close();
            return exesizes;
        }

    }
}
