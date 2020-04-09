// using System.IO;
using System;
using Iron_Ninja.Models;
namespace Iron_Ninja {
    class Program {
        static void Main (string[] args) {
            Buffet b1 = new Buffet ();
            SweetTooth sw1 = new SweetTooth ();
            SpiceHound Sp1 = new SpiceHound ();
            while(!sw1.isFull){
                sw1.Consume(b1.Serve());
            }
            while(!Sp1.isFull)
            {
                Sp1.Consume(b1.Serve());
            }
            if(sw1.ConsumtionHistory.Count > Sp1.ConsumtionHistory.Count)
            {
                Console.WriteLine($"Spice Hound had {Sp1.ConsumtionHistory.Count} items.");
            }
            else
            {
                Console.WriteLine($"Sweet Tooth had {sw1.ConsumtionHistory.Count} items.");
            }
        }
    }
}