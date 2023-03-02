using System;

namespace Tamagotchidz
{
    class Program
    {
        static void Main(string[] args)
        {// создали кошку
            Cat cat = new Cat();
            cat.Meow(); //помяукала
            // создали фрукт яблоко
            Fruit fruitApple = new Fruit { health = 10 };
            // создали фрукт апельсин
            cat.Eat(fruitApple);
            Fruit fruitOrange = new Fruit { health = 5 };
            cat.Eat(fruitOrange);
            DoMeal(cat, fruitApple); // покормили яблоком
            DoMeal(cat, fruitApple); // покормили яблоком
            DoMeal(cat, fruitOrange); // покормили апельсином
            cat.Play();
            cat.Run();

        }
        static void DoMeal(Cat c, Fruit f)
        {
            c.Eat(f); //кошка {имя кошки} съела фрукт
        }

    }
}