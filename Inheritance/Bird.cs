using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class

    /*Create an object of your Bird class
    *  give values to your members using the object of your Bird class
    *  
    * Creatively display the class member values 
    */

    public class Bird : Animal
    {
        public Bird()
        {
            Eyes = true;
            Legs = 2;
            Tail = true;
            Swims = false;

        }

        public bool Flies { get; set; }
        public bool Nocturnal { get; set; }
        public bool Migrates { get; set; }
        public bool Claws { get; set; }

    }
}
