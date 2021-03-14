using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Controllers
{
    class LoginController
    {
        public static bool checkLogin(string name, string status)
        {
            
            if(Database.DataLogic.getUsers($"WHERE Name LIKE '{name}'").Count > 0 && Database.DataLogic.getStatus($"WHERE Name LIKE '{status}'").Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
                    
        }
        
    }
}
