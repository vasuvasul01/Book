using Microsoft.Extensions.Configuration;
using System.IO;

namespace Book.API.DatabaseContext
{
    public class SQLConnection
    {
        public static string SqlConnection { get; set; }
        static SQLConnection()
        {
            var Configbuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            Configbuilder.AddJsonFile(path, false);
            var root = Configbuilder.Build();
            var appsetting = root.GetSection("Connection:ConnectionString");
            SqlConnection = appsetting.Value;
        }
    }
}
