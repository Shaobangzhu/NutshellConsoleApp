using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using NutshellConsoleApp.Models;

namespace NutshellConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=DotnetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";

            IDbConnection dbConnection = new SqlConnection(connectionString);

            string sqlCommand = "SELECT GETDATE()";

            DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);

            Console.WriteLine(rightNow);

            // Computer myComputer = new Computer()
            // {
            //     Motherboard = "Z690",
            //     HasWifi = true,
            //     HasLTE = false,
            //     ReleaseDate = DateTime.Now,
            //     Price = 943.87m,
            //     VideoCard = "RTX 4060"
            // };

            // myComputer.HasWifi = false;
            // Console.WriteLine(myComputer.Motherboard);
            // Console.WriteLine(myComputer.HasWifi);
            // Console.WriteLine(myComputer.ReleaseDate);
            // Console.WriteLine(myComputer.VideoCard);   
        }
    }
}
