using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Boxer : Dog {

        public override string GetTypeofDog() {
            return "Boxer";
        }

        public Boxer(string Name) : base(Name) {
            this.LongTail = false;
        }

        public Boxer() {

        }
    }
}
