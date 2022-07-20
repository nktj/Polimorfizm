namespace Polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                "Валера",
                "Улица ..., дом ...",
                10000,
                300
                );
        
            Console.WriteLine("Список товаров:");

            Steak tomagafkSteak = new Steak(
                "Томагафк", 
                "Стейк-топор",
                2200, 
                "Мясник"
                );

            Steak shatoBrian = new Steak(
                "Шато-бриан",
                "Оу-май",
                5000,
                "Unknown"
                );

            Fruit banan = new Fruit(
                0,
                "Бананчик",
                100, 
                "Добрый банан"
                );
           
            Yogurt yogurt = new Yogurt(
                25, 
                "Молочное чудо", 
                85, 
                "Unknown"
                );

            Product[] products = new Product[]
            {
                tomagafkSteak,
                shatoBrian,
                banan,
                yogurt
            };                                 //Произошел upcast

            foreach (Product product in products)
            {
                product.ToConsole();
            }

            Informer informer = new Informer();

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine($"Ну так {user.Name} у вас {user.Balance} монет");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберите номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);

                if (productNumber >= 0 && productNumber < products.Length)
                {
                    if (products[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("Где деньги");
                    }
                } 
                else
                {
                    Console.WriteLine("Такого нет, ты куда нажал");
                }
            }
        }
    }
}