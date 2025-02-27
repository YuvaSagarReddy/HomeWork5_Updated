using System;
namespace Homework_5
{
    public class Animals
    {
        public string Name { get; set; }

        public Animals(string name)
        {
            Name = name;
        }

        public virtual string MakeSound()
        {
            return "Some generic animal sound";
        }
        public override string ToString()
        {
            return $"Animal: {Name}, Sound: {MakeSound()}";
        }
    }
    public class Dog:Animals
    {
        public Dog(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return "Bark";
        }
    }

    public class Cat:Animals
    {
        public Cat(string name) : base(name)
        {
        }
        public override string MakeSound()
        {
            return "Meow";
        }
    }
}

