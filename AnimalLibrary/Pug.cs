using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Pug : Dog {

        public bool SmallSize { get; set; }

        public override string GetTypeofDog() {
            return "Pug";
        }

        public Pug(string Name) : base(Name) {
            this.LongTail = false;
            SmallSize = true;
            this.Muzzle = MuzzleType.Collapsed;
        }

        public Pug() : this("Spot") {

        }

    }
}
