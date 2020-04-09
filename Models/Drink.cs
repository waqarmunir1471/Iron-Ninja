using System.Runtime.CompilerServices;
namespace Iron_Ninja.Models {
    class Drink : IConsumable {
        public string Name { get; set; }
        public int Calories { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }

        public string GetInfo(){
            return $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        public Drink(string _name, int cal,bool sp, bool sw){
            Name = _name;
            Calories= cal;
            IsSpicy=sp;
            IsSweet=sw;
        }
        // Implement a GetInfo Method
        // Add a constructor method
    }
}