
using System;
using System.Collections.Generic;

namespace Iron_Ninja.Models
{
    public class Buffet
    {
        public List<IConsumable> Menu;
        public Buffet(){
            Menu = new List<IConsumable>(){
            new Drink("Frozen Hot Choclate",700,true,false),
            new Drink("Frapichino",400,true,false),
            new Drink("Mocha",900,true,false),
            new Food("Hot Choclate",700,false,true),
            new Food("Monster",700,false,true),
            new Food("RedBull",700,false,true),
            new Food("Coke",700,true,false)
            };
        }
        public IConsumable Serve(){
            Random rand = new Random();
            int count = Menu.Count;
            Console.WriteLine(Menu.Count);
            IConsumable SelectedFood = Menu[rand.Next(count)];
            Console.WriteLine(Menu[rand.Next(count)]);
            Console.WriteLine(SelectedFood.Name);
        return SelectedFood;
        }
    }
}