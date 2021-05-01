using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceCalc = new PriceCalculator();
            var clients = new Client[]
            {
                new Client("Михаил", new Terrier("Муся")),
                new Client("Алёна", new Bulldog("Тыква")),
                new Client("Александра", new Pug("Жека")),
                new Client("Евгений", new RussianBlue("Мура")),
                new Client("Петр", new SphynxCat("Лыска")),
                new Client("Вася", new BritishCat("Дыва"))
            };

            foreach (var client in clients)
            {
                Console.WriteLine($"{client} Цена услуг: {priceCalc.Calculate(client.Pet)}");
            }
        }
    }
}
