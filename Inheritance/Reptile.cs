using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class

    public class Reptile : Animal
    {
        public Reptile()
        {

        }

        public bool ColdBlooded { get; set; }
        public bool ShedsSkin { get; set; }
        public bool Vertabrate { get; set; }
        public bool ProduceEggs { get; set; }
    }
}
