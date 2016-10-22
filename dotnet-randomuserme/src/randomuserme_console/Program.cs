using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Services;
using Models;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RunRandomusermeServiceAsync().Wait();
        }

        public static async Task RunRandomusermeServiceAsync()
        {
            RandomUserMeSearch randomuser = await RumService.GetRandomUsers();
            Console.WriteLine("####################################################################");
            Console.WriteLine("##                           Randomuserme App                     ##");
            Console.WriteLine("## -------------------------------------------------------------- ##");
            Console.WriteLine("## Data from Forecast.io Service                                  ##");
            Console.WriteLine("## Developed by Philippe De Pauw - Waterschoot (drdynscript)      ##");
            Console.WriteLine("## Arteveldehogeschool                                            ##");
            Console.WriteLine("####################################################################");
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(String.Format("Gender: {0}", randomuser.Users.Gender));
            
            //Console.ResetColor();
            Console.WriteLine("####################################################################");
        }
    }
}
