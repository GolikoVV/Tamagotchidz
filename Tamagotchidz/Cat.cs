using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchidz
{
    struct Fruit
    {
        public string type;
        public int hunger;

    }
    
    class Cat
    {
        public void Meow() //кошка может мяукать
        {
            Console.WriteLine("meow! ");
        }
        public void Eat(Fruit f)
        {
            Console.WriteLine($"Cat eats{f.type}. {f.health} hp.");
        }
        public void Play()
        {
            hunger -= 30;
            Console.WriteLine($"stop feeding the cat" + hunger);

        }
        public void Run()
        {
            hunger -= 0;
            Console.WriteLine($"need to feed the cat" + hunger");
        }
    } 
}       
         
      