namespace OOP_Polymorphism
{
    using System;
    //Noa Denise Ishac NET23
    class Program
    {
        static void Main()
        {
            //skapar en array och instanser av varje klass som sedan loopas igenom
            Geometri[] shapes = new Geometri[]
            {
            new Rektangel(),
            new Fyrkant(),
            new Cirkel(),
            new Parallellogram(),
            new Ellips()
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area: {shape.Area()}");
            }
        }
    }
}