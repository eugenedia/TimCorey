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
            PlayerInfoModel player1 = CreatePlayer("Player 1");
            PlayerInfoModel player2 = CreatePlayer("Player 2");
            
            Console.ReadLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("Created by Tim Corey");
            Console.WriteLine();
        }

        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"Player information for { playerTitle }");

            // Ask the user for their name
            output.UsersName = AskForUsersName();
            // Load up the shot grid
            GameLogic.InitializeGrid(output);
            // Ask the user for their 5 ships placements
            PlaceShips(output);
            // Clear
            Console.Clear();

            return output;
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
                
        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you want to place your next ship number { model.ShipLocations.Count + 1 }: ");
                string location = Console.ReadLine();

                bool isValidLocation = GameLogic.PlaceShip(model, location);

                if (isValidLocation == false )
                {
                    Console.WriteLine("This was not valid location. Please try again.");
                }

            } while (model.ShipLocations.Count < 5);
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
