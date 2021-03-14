using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Database
{
    class DataObjects
    {
        public class Users
        {
            //9
            public string Id;
            public string Name;
            public string StatusId;
            public string BirthDate;
            public string Hieght;
            public string Mass;
        }
        public class Status
        {
            public string Id;
            public string Name;
        }
        public class Food
        {
            public string Id;
            public string Name;
            public string UserId;
            public string Callory;
            public string Mass;
            public string Description;
        }
        public class Exesize
        {
            public string Id;
            public string Name;
            public string Counts;
            public string Repeats;
            public string StartDate;
            public string EndDate;
            public string UserId;
            public string RecomendedFood;
        }
    }
}
