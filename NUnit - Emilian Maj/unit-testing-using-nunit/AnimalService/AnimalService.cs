using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnimalClass
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

        public string Filename 
        { 
            get
            {
                return this.filename;
            } 
            set 
            {
                this.filename = value;
            } 
        }

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

    public class Animal                             //-> public
    {
        public virtual string MakeSound()
        {
            return "Animal gives a sound!";
        }
    }

    public class Dog : Animal                       //-> public
    {
        public override string MakeSound()
        {
            return "Dog sounds like: hau hau !";
        }
    }

    public class Cat : Animal                       //-> public
    {
        public override string MakeSound()
        {
            return "Cat says: meow meow !";
        }
    }
}
