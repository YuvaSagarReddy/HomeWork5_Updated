using System;
namespace Homework_5
{
    public class Vehicles
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicles(string amake, string amodel, int ayear)
        {
            Make = amake;
            Model = amodel;
            Year = ayear;
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }
    }

    public class Car : Vehicles
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} with {NumberOfDoors} doors";
        }
    }

    public class Motorcycle : Vehicles
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string make, string model, int year, bool hasSidecar) : base(make, model, year)
        {
            HasSidecar = hasSidecar;
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} (Has Sidecar: {HasSidecar})";
        }
    }
}