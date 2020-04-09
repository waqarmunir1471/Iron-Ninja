using System.Collections.Generic;
namespace Iron_Ninja.Models
{
    public abstract class Ninja
    {
        protected int CaloriesInTake;
        public int CalinTake{
            get{
                return CaloriesInTake;
            }
        }
        public List<IConsumable> ConsumtionHistory;
        public Ninja(){
            CaloriesInTake=0;
            ConsumtionHistory = new List<IConsumable>();
        }
        public abstract bool isFull {get;}
        public abstract void Consume(IConsumable item);

    }
}