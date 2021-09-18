using System;
namespace Episode009
{
    public struct Fruit
    {
        public Fruit(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public string Name { get; set; }
        public string Color { get; set; }
    }
}
