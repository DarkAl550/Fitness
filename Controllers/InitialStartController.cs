using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Controllers
{
    class InitialStartController
    {
        public static void createServerLogFile(string pcName, string databaseName, bool integratedSecurity)
        {
            string writePath = @"serverlog";

            string text = $"Data Source={pcName}\\SQLEXPRESS;Initial Catalog={databaseName};Integrated Security={integratedSecurity}"; ;
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static string checkServerPath()
        {
            string path = @"serverlog";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        } 
    }
}
