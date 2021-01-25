using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        // Interface is a contract
        // Classes implement interfaces

        static void Main(string[] args)
        {

            List<IComputerController> controllers = new List<IComputerController>();

            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();

            controllers.Add(keyboard);
            controllers.Add(gameController);

            foreach(IComputerController controller in controllers)
            {
                controller.
            }


            
            Console.ReadLine();
        }
    }

    public interface IComputerController
    {
        void Connect();
        void CurrentKeyPressed();

    }


    public class Keyboard : IComputerController
    {
        public void Connect()
        {

        }

        public void CurrentKeyPressed()
        {

        }

        public string ConnectionType { get; set; }
    }

    public class GameController : IComputerController
    {
        public void Connect()
        {
        }

        public void CurrentKeyPressed()
        {
        }

        public int BatteryLevel { get; set; }
    }
}
