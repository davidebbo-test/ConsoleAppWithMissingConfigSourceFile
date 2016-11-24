using System.Configuration;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // This line works fine because config system ignores missing 'appSettings file='
            string foo = ConfigurationManager.AppSettings["foo"];

            // This line blows up because config system doesn't allow missing 'connectionStrings configSource='
            ConnectionStringSettings bar = ConfigurationManager.ConnectionStrings["bar"];
        }
    }
}
