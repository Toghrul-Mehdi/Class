namespace AvtoSalon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Opel","Astra",5000,4);
            car1.ShowFullInfo();
            Car car2 = new Car("Honda", "Insight", 7000, 4);
            car2.ShowFullInfo();
            Car car3 = new Car("Hyundai", "Santafe", 8000, 4);
            car3.ShowFullInfo();

            Motorcycle moto1 = new Motorcycle("Ducati","Multistrada",3000,2);
            moto1.ShowFullInfo();
            Motorcycle moto2 = new Motorcycle("Ducati", "Scrambler", 4000, 2);
            moto2.ShowFullInfo();
            Motorcycle moto3 = new Motorcycle("Ducati", "Panigale", 2000, 2);
            moto3.ShowFullInfo();
        }
    class Vehicle
        {
            public string Brand;
            public string Model;
            public double Mile;
            public Vehicle(string brand ,string model, double mile) 
            {
                if(string.IsNullOrEmpty(model) || string.IsNullOrEmpty(brand))
                {
                    throw new ArgumentNullException("Marka ve model mutleq qeyd olunmalidir!");
                }
                Brand = brand;
                Model = model;
                Mile = mile;
            }
            public void ShowFullInfo()
            {
                Console.WriteLine($"Brand:{Brand},Model:{Model},Mile:{Mile}");
            }
        }
    class Car : Vehicle
        {
            public int DoorsNum;
            public Car(string brand, string model, double mile, int doorsNum) : base(brand, model, mile)
            {
                DoorsNum = doorsNum;
            }

            public void ShowFullInfo()
            {
                base.ShowFullInfo();
                Console.WriteLine($"Qapi sayi: {DoorsNum}");
            }
        }
    class Motorcycle:Vehicle
        {
            public int WheelNum;

            public Motorcycle(string brand, string model, double mile, int wheelNum):base(brand, model, mile)
            {
                WheelNum = wheelNum;
            }

            public void ShowFullInfo()
            {
                base.ShowFullInfo();
                Console.WriteLine($"Teker sayi: {WheelNum}");
            }
        }
    
    }
}
