using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;

namespace BattleshipLiteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            
            
            Console.ReadLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("Created by Tim Corey");
            Console.WriteLine();
        }

        private static PlayerInfoModel CreatePlayer()
        {
            PlayerInfoModel output = new PlayerInfoModel();

            // Ask the user for their name
            output.UsersName = AskForUsersName();
            // Load up the shot grid
            GameLogic.InitializeGrid(output);
            // Ask the user for their 5 ships placements
            // Clear
        }

        void ClearDisplay()
        {

        }

        private static string AskForUsersName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }

        private static void PlaceShips()
        {

        }

        bool IsValidSpotForShip()
        {
            return true;
        }

        void CreateTheGridForEachUser()
        {

        }

        void PrintOutTheGrid()
        {

        }

        void FireOnOpponent()
        {

        }

        bool IsShotCanBeTaken()
        {
            return true;
        }

        void DisplayScore()
        {

        }

        void PrintWinnerAndShotsTaken()
        {

        }



    }
}
