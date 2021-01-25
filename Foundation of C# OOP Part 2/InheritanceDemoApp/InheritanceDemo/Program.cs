using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Phone> phones = new List<Phone>();

            phones.Add(new Cellphone());
            phones.Add(new Smartphone());

            foreach(var phone in phones)
            {
                if (phone is Cellphone cell)
                {
                    cell.Carrier = "";
                }

                if (phone is Smartphone smartphone)
                {
                    smartphone.ConnectToInternet();
                }
            }


            Car greenCar = new Car();

            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Car());

            vehicles.Add(new Boat());

            vehicles.Add(new Motorcycle());

            foreach(var vehicle in vehicles)
            {
                if (vehicle is Car car)
                {
                    car.Brand = "Suzuki";
                }

                if (vehicle is Boat boat)
                {
                    boat.Sailing();
                }

            }

            Console.ReadLine();
        }
    }


}

