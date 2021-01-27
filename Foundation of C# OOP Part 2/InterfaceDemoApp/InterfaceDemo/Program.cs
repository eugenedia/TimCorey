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
            BatteryPoweredGameController battery = new BatteryPoweredGameController();
            BatteryPoweredkeyboard batteryKeyboard = new BatteryPoweredkeyboard();

            controllers.Add(keyboard);
            controllers.Add(gameController);
            controllers.Add(battery);

            foreach (IComputerController controller in controllers)
            {
                if (controller is GameController gc)
                {

                }

                if (controller is IBatteryPowered powered)
                {
                    int batteryLevel = powered.BatteryLevel;

                }
            }

            using (GameController gc = new GameController())
            {

            }

            List <IBatteryPowered> powereds = new List<IBatteryPowered>();

            powereds.Add(battery);
            powereds.Add(batteryKeyboard);

            Console.ReadLine();
        }
    }
}
