using System;
namespace Iron_Ninja.Models
{
    public class SweetTooth : Ninja
    {
        
        public override bool isFull {
            get{
                return CaloriesInTake >= 1500;
            }
        }
        // public SweetTooth(bool isFull):base(isFull)
        // {

        // }
        public override void Consume(IConsumable item){
            if(!isFull){
                CaloriesInTake+=item.Calories;
                if(item.IsSweet){
                    CaloriesInTake+=10;
                }
                ConsumtionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
            }else{
                Console.WriteLine("Ninja is Full of Calories No More Food Need");
            }
        }
    }
}