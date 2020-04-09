using System;

namespace Iron_Ninja.Models {
    public class SpiceHound : Ninja {
        public override bool isFull {
            get {
                return CaloriesInTake >= 1200;
            }
        }
        public override void Consume (IConsumable item) {
            if (!isFull) {
                CaloriesInTake += item.Calories;
                if (item.IsSpicy) {
                    CaloriesInTake -= 5;
                }
                ConsumtionHistory.Add (item);
                Console.WriteLine (item.GetInfo ());
            } else {
                Console.WriteLine ("Ninja is Full of Calories No More Food Need");
            }
        }
    }
}