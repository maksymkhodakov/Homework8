using System;

namespace Solid_4
{
    /*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/
// Interface segregation principle!

    internal interface ISoldable
    {
        void SetPrice(double price);
    }

    internal interface IDiscountable
    {
        void ApplyDiscount(string discount);
        void ApplyPromocode(string promocode);
    }

    internal interface IShapeable
    {
        void SetColor(byte color); 
        void SetSize(byte size);
    }

    internal class Book : ISoldable, IDiscountable
    {
        private double Price { get; set; }
        private string Discount { get; set; }
        private string Promocode { get; set; }
        
        public void SetPrice(double price)
        {
            Price = price;
        }

        public void ApplyDiscount(string discount)
        {
            Discount = discount;
            Console.WriteLine("Applying discount");
        }

        public void ApplyPromocode(string promocode)
        {
            Promocode = promocode;
            Console.WriteLine("Applying promocode");
        }
    }

    internal class Clothes : ISoldable, IDiscountable, IShapeable
    {
        private double Price { get; set; }
        private string Discount { get; set; }
        private string Promocode { get; set; }
        private byte Color { get; set; }
        private byte Size { get; set; }
        
        public void SetPrice(double price)
        {
            Price = price;
        }

        public void ApplyDiscount(string discount)
        {
            Discount = discount;
            Console.WriteLine("Applying discount");
        }

        public void ApplyPromocode(string promocode)
        {
            Promocode = promocode;
            Console.WriteLine("Applying promocode");
        }

        public void SetColor(byte color)
        {
            Color = color;
        }

        public void SetSize(byte size)
        {
            Size = size;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
       
            Console.ReadKey();
        }
    }
}