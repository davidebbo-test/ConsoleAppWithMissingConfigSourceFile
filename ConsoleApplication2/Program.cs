using System.Configuration;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string foo = ConfigurationManager.AppSettings["foo"];
            ConnectionStringSettings bar = ConfigurationManager.ConnectionStrings["bar"];
        }
    }
}
