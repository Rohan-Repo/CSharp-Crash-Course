using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Console_App_5
{
    internal class InterfaceEg
    {
        public interface Animal
        {
            public void makesSound();
        }

        class Dog : Animal
        {
            public void makesSound()
            {
                Console.WriteLine( "Dog says Woof!" );
            }
        }

        class Cat : Animal
        {
            public void makesSound()
            {
                Console.WriteLine("Cat says Meow!");
            }
        }

        class Cow : Animal
        {
            public void makesSound()
            {
                Console.WriteLine("Cow says Moo!");
            }
        }

        //static void Main(string[] args)
        //{
        //    Animal dog = new Dog();
        //    dog.makesSound();

        //    Animal cat = new Cat();
        //    cat.makesSound();

        //    Animal cow = new Cow();
        //    cow.makesSound();

        //}
    }
}
