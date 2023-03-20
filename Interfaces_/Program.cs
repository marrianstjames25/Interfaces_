using System;
using System.ComponentModel;

namespace Interfaces_
{
    internal class Program
    {
        static void Main(string[] args)

        {

            // interface = defines a "contract" that all the classes inheriting from should follow

            //An interface declares "what a class should have"

            //An inheriting class defines "how it should do it"

            //Benefit = security + multiple inheritance 

            //Interfaces specify what a class must do and not how.
            //Interfaces can’t have private members.
            //By default all the members of Interface are public and abstract.
            //The interface will always defined with the help of keyword ‘interface‘.
            //Interface cannot contain fields because they represent a particular implementation of data.
           //Multiple inheritance is possible with the help of Interfaces but not with classes.



            Rabbit rabbit = new Rabbit();
            rabbit.Flee();

            Hawk hawk = new Hawk();
            hawk.Hunt();

            Fish fish = new Fish();

            fish.Hunt();
            fish.Flee();


     

        }

        interface IPrey
        {
            void Flee();

        }
        interface IPredator
        {
            void Hunt();
        }

        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is looking for food");
            }
        }
        class Rabbit : IPrey
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }
        }

        class Fish : IPrey, IPredator //here we can have multiple ineritance since fish can be both prey and predators 
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs away!");
            }

            public void Hunt()
            {
                Console.WriteLine("The hawk is looking for food");
            }
        }



    }

}
