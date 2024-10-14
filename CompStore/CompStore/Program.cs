namespace CompStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook Acer = new Notebook("Acer", "Yaxsi kompdu", 3, 2500, 16, 512);
            Acer.ShowFullData();
            Notebook Hp = new Notebook("Hp", "Yaxsi kompdu", 4, 1500, 8, 256);
            Hp.ShowFullData();
            Notebook Lenovo = new Notebook("Lenovo", "Yaxsi kompdu", 0, 1500, 8, 512);
            Lenovo.ShowFullData();
        }
    class Product
        {
            public string Name;
            public string Description;
            public int Count;
            public bool IsStock = true;
            public double Price;

            public Product(string name, string description, int count, double price)
            {
                Name = name;
                Description = description;
                Count = count;
                Price = price;
            }

            public void Sale(string name, string description, int count, double price)
            {
                
                Name = name;
                Description = description;
                Count = count;
                Price = price;
            }
            public void ShowFullData()
            {
                Console.WriteLine($"Name:{Name},Description:{Description},Price:{Price},Count:{Count},Price:{Price}");
            }

        }
        class Notebook : Product
        {
            public byte Ram;
            public int Storage;
            public Notebook(string name, string description, int count, double price, byte ram, int storage) : base(name, description, count, price)
            {
                if (string.IsNullOrEmpty(name)|| count==' ' || price==' ' ||  ram==' ')
                {
                    throw new ArgumentException("Verilenler daxil edilmeyib");
                }
                else if (count==0)
                {
                    throw new ArgumentException("Mehsul stokda yoxdu");
                }
                Ram = ram;
                Storage = storage;

            }
            public void ShowFullData()
            {
                base.ShowFullData();
                Console.WriteLine($"Ram:{Ram},Storage:{Storage}");
            }

        }
    }
}