using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    class Product
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public virtual double GetDiscountPrice(User user)
        {
            if (user.Spent < 300)
            {
                return Price;
            }

            if (user.Spent < 1000)
            {
                return Price * 0.9;
            }

            return Price * 0.8;
        }

        public virtual void ToConsole()
        {
            Console.WriteLine(ToString()+ ":");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Производитель: " + Manufacturer);
        }
    }

    class Steak : Product
    {
        public string Type { get; private set; }
        public Steak(string type, string name, int price, string manufacturer)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Type = type;
        }

        public override string ToString()
        {
            return "Стейк";
        }

        public override void ToConsole()
        {
            base.ToConsole();
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine(new String('-', 25));
        }
    }

    class Fruit : Product
    {
        public int Freshness { get;  set; }

        public Fruit(int freshness, string name, int price, string manufacturer)
        {
            Freshness = freshness;
            Name = name;
            Price=price;
            Manufacturer = manufacturer;
        }

        public void LoseFreshness(int freshness)
        {
            Freshness--;
        }

        public override string ToString()
        {
            return "Фрукт";
        }

        public override void ToConsole()
        {
            base.ToConsole();
            Console.WriteLine("Свежесть: " + Freshness);
            Console.WriteLine(new String('-', 25));
        }
    }

    class Yogurt : Product
    {
        public int ExpirationDate { get; private set; }
        public Yogurt(int expirationDate, string name, int price, string manufacturer)
        {
            ExpirationDate = expirationDate;
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
        }

        public override double GetDiscountPrice(User user)
        {
            return Price/2;
        }

        public override string ToString()
        {
            return "Йогурт";
        }

        public override void ToConsole()
        {
            base.ToConsole();
            Console.WriteLine("Срок годности: " + ExpirationDate + " дней");
            Console.WriteLine(new String('-', 25));
        }
    }

}



