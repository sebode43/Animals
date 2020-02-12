using System;

namespace AnimalLibrary {

    public enum MuzzleType { Long, Short, Collapsed }; //outside because other classes are going to use and so you wouldn't reference the class you everytime you use it
    public enum PitchType { High, Medium, Low };

    public class Dog {

        public bool LongTail { get; set; } //long or short
        public PitchType BarkPitch { get; set; } 
        public MuzzleType Muzzle { get; set; } 
        public bool ExtremeSenseofSmell { get; set; } = false; //normal or extreme
        public string Name { get; set; }
        
        public virtual string GetTypeofDog() {
            return "Dog";
        }

        public Dog(string Name) {
            if (Name == null) {
                this.Name = "Doggo";
            } else {
                this.Name = Name;
            }
        }

        public Dog() {

        }


    }
}
