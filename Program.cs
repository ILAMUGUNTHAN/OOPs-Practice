using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Vehicle
    {
        //Implementing encapsulation by having private members and creating public properties
        private string make;
        private string model;
        private int year;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Vehicle(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {year} {make} {model}");
        }
    }

    // Inheritance and Polymorphism
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car: {Year} {Make} {Model}, Doors: {NumberOfDoors}");
        }
    }

    // Abstract class and interface
    abstract class Appliance
    {
        public abstract void Operate();
    }

    interface IPortable
    {
        void Move();
    }

    // Implementing interface and abstract class
    class Laptop : Appliance, IPortable
    {
        public override void Operate()
        {
            Console.WriteLine("Laptop is operating.");
        }

        public void Move()
        {
            Console.WriteLine("Laptop is being moved.");
        }
    }

    // Static class and method
    static class Helper
    {
        public static void PrintSeparator()
        {
            Console.WriteLine(new string('-', 35));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            

            Helper.PrintSeparator();

            // Working with encapsulation and inheritance
            Vehicle vehicle = new Vehicle("Toyota", "Corolla", 2020);
            vehicle.DisplayInfo();

            Car car = new Car("Honda", "Civic", 2021, 4);
            car.DisplayInfo();

            Helper.PrintSeparator();

            // Working with abstraction and interface
            Laptop laptop = new Laptop();
            laptop.Operate();
            laptop.Move();

            Helper.PrintSeparator();

            //Implementing Exception handling with dividing a number by 0
            Console.WriteLine("Performing Exception handling through division");
            Helper.PrintSeparator();
            try
            {
                Console.Write("Enter a divisor to divide 10: ");

                int divisor = int.Parse(Console.ReadLine());
                Console.WriteLine($"Result: {10 / divisor}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

            Helper.PrintSeparator();

            Console.WriteLine("Program executed successfully.");

            Console.ReadLine();
        }
    }
}
