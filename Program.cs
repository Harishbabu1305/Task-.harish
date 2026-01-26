using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exception_handling___Interface
{
    internal static class Program
    {using System;

// 1
class Vehicle
    {
        public string Brand;
        public int Speed;

       
        public Vehicle()
        {
            Brand = "Unknown";
            Speed = 0;
        }

        public Vehicle(string brand)
        {
            Brand = brand;
            Speed = 0;
        }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }

        public void Display()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed}");
        }
    }

    class Car : Vehicle
    {
        public int Doors;

        public Car(string brand, int speed, int doors) : base(brand, speed)
        {
            Doors = doors;
        }

        public void CarDetails()
        {
            Console.WriteLine($"Car Brand: {Brand}, Speed: {Speed}, Doors: {Doors}");
        }
    }

    class Bike : Vehicle
    {
        public bool HasGear;

        public Bike(string brand, int speed, bool hasGear) : base(brand, speed)
        {
            HasGear = hasGear;
        }

        public void BikeDetails()
        {
            Console.WriteLine($"Bike Brand: {Brand}, Speed: {Speed}, Has Gear: {HasGear}");
        }
    }

    //2 
    class Payment
    {
        public virtual void MakePayment()
        {
            Console.WriteLine("Processing payment...");
        }
    }

    class CreditCard : Payment
    {
        public override void MakePayment()
        {
            Console.WriteLine("Payment made using Credit Card");
        }
    }

    class NetBanking : Payment
    {
        public override void MakePayment()
        {
            Console.WriteLine("Payment made using Net Banking");
        }
    }

    class UPI : Payment
    {
        public override void MakePayment()
        {
            Console.WriteLine("Payment made using UPI");
        }
    }

    // 3
    class PaymentOverload
    {
        public void MakePayment(int amount)
        {
            Console.WriteLine("Paid ₹" + amount + " in cash");
        }

        public void MakePayment(int amount, string mode)
        {
            Console.WriteLine("Paid ₹" + amount + " using " + mode);
        }
    }

    // 4
    class Program
    {
        static void Main()
        {
            Console.WriteLine("---- Inheritance & Constructor Overloading ----");
            Car car = new Car("Toyota", 180, 4);
            car.Start();
            car.CarDetails();

            Bike bike = new Bike("Yamaha", 120, true);
            bike.Start();
            bike.BikeDetails();

            Console.WriteLine("\n---- Polymorphism (Overriding) ----");
            Payment p;

            p = new CreditCard();
            p.MakePayment();

            p = new NetBanking();
            p.MakePayment();

            p = new UPI();
            p.MakePayment();

            Console.WriteLine("\n---- Polymorphism (Overloading) ----");
            PaymentOverload po = new PaymentOverload();
            po.MakePayment(500);
            po.MakePayment(1500, "Credit Card");
        }
    }
}
