using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            HasFeathers = true;
        }

        public string Type { get; set; }
        public int FlightSpeed { get; set; }
        public int WingSpan { get; set; }
        public bool IsFlamingo { get; set; }

    }
}
