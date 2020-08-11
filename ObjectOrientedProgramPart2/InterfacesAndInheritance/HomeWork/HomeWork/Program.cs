using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRunnable> runnable = new List<IRunnable>();

            People people = new People();

            Animal animal = new Animal();

            runnable.Add(people);
            runnable.Add(animal);

            foreach(IRunnable rb in runnable)
            {
                rb.Run();

                if(rb is People ppl)
                {
                    ppl.Read();
                }

                if(rb is Animal an)
                {
                    an.DrinkWater();
                }
            }

            Console.ReadLine();
        }


        
    }

    public class People: IRunnable
    {
        public void Read()
        {
            Console.WriteLine("People read");
        }

        public void Run()
        {
            Console.WriteLine("People run");
        }
    }

    public class Animal: IRunnable
    {
        public void  DrinkWater()
        {
            Console.WriteLine("Animal drink water");
        }

        public void Run()
        {
            Console.WriteLine("Animal run");
        }
    }

    public interface IRunnable
    {
        void Run();
    }

}
