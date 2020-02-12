using System;
using System.Collections.Generic;
using AnimalLibrary;

namespace Animals {
    class Program {
        static void Main(string[] args) {
           
            var gs1 = new GermanShepherd("Gerald");
            
            var GermanShepherd = new GermanShepherd {
                BarkPitch = PitchType.Low,
                Name = "Shep"
            };

            var Pug = new Pug("Sheldon");
            var Pug2 = new Pug();

            var Doug = new Dog {
                LongTail = false,
                BarkPitch = PitchType.High,
                Muzzle = MuzzleType.Collapsed,
                ExtremeSenseofSmell = false,
                Name = "Doug"
            };

            var Boxer = new Boxer();

            var dogs = new List<Dog>(); //polymorphism example
            dogs.Add(Boxer);
            dogs.Add(Doug);
            dogs.Add(Pug2);
            dogs.Add(Pug);
            dogs.Add(GermanShepherd);
            dogs.Add(gs1);

            foreach(var dog in dogs) {
                Console.WriteLine(dog.GetTypeofDog()); //ends example
            }


        }
    }
}
