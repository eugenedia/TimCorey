using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<InventoryItemModel> inventory = new List<InventoryItemModel>();

            inventory.Add(new VehicleModel { DealerFee = 25, ProductName = "Kia Optima" });
            inventory.Add(new BookModel { ProductName = "A Tale of Two Cities", NumberOfPages = 200 });

            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasable = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 50, ProductName = "Polo Sedan", QuantityInStock = 100 };
            var book = new BookModel { ProductName = "Fellowship of the ring" };
            var excavator = new ExcavatorModel { ProductName = "Buldozer", QuantityInStock = 2 };

            Console.ReadLine();
        }
    }

    public interface IRentable
    {
        void Rent();
        void ReturnRental();
    }

    public interface IPurchasable
    {
        void Purchase();
    }

    public class InventoryItemModel
    {
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
    }

    public class VehicleModel: InventoryItemModel, IPurchasable, IRentable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been purchased");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This vehicle has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("This vehicle has been returned");
        }
    }

    public class BookModel : InventoryItemModel, IPurchasable
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This book has been purchased");
        }
    }

    public class ExcavatorModel: InventoryItemModel, IRentable
    {
        public void Dig()
        {
            Console.WriteLine("I am digging");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            Console.WriteLine("This excavator has been rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            Console.WriteLine("The excavator has been returned");
        }
    }


}
