using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Tutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BuildWebHost(args).Run();

            // Write to console
            Console.WriteLine("Welcome to the C# Station Tutorial!");

            // keep screen from going away
            // when run from VS.NET
            Console.ReadLine();
        }



        //public static IWebHost BuildWebHost(string[] args) =>
            //WebHost.CreateDefaultBuilder(args)
                //.UseStartup<Startup>()
                //.Build();
    }
}
