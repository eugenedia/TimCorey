using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = @"ker\tb";
            string lastName = @"bdeg\nk";

            string fullName = $"{ firstName } {lastName}";


            double averageWordPerMinute = 34.24;
            decimal costPerContainer = 27.45M;

            Console.WriteLine(fullName);

            bool isAlive = false;

            Console.ReadLine();
        }
    }
}
