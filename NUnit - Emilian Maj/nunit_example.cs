using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Zadanie_nr_1
{
    interface IExample
    {
        string Filename { get; set; }
        void PrintToConsole();
        void WriteToFile();
        List<string[]> OrderBy(int i);
        List<string[]> Reverse();
    }
    class Tea2 : IExample
    {
        string filename;

        public string Filename { get {return this.filename;} set {this.filename = value;} }

        public Tea2(string filename = "halo ja zyje.")
        {
            Filename = filename;
        }
        public void PrintToConsole()
        {

        }
        public void WriteToFile()
        {

        }
        public List<string[]> OrderBy(int i)
        {
            return new List<string[]>();
        }
        public List<string[]> Reverse()
        {
            return new List<string[]>();
        }
    }

    abstract class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal gives a sound!");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog sounds like: hau hau !");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat says: meow meow !");
        }
    }
}
