using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            HasFeathers = false;
        }

        public string Type { get; set; }
        public bool CanSwim { get; set; }
        public bool IsPretty = false;
        public int Length { get; set; }
    }
}
