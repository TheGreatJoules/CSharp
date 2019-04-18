using System;

// Casting and Type Conversions
using Implicit_Block;
using Explicit_Block;

namespace Conversions
{ 
    class Program
    {
        static void Main(string[] args)
        {
            ConversionImplicit objectA = new ConversionImplicit();
            ConversionExplicit objectB = new ConversionExplicit();

            objectB.Test1();
            objectA.Test1();
        }
    }
}

namespace Implicit_Block
{
    // Implicit Conversions. num long can
    // hold any value an int can hold, and more!
    class ConversionImplicit
    {
        public void Test1()
        {
            /*  For built in numeric types an implicit converion
                can be made when the value to be stored can fit
                into the variable without being trunctated or rounded
                off.
            */

            int num = 2147483647;
            long bigNum = num;

            /*
                For reference types, an implicit conversion always exisits from a
                class to any one of its direct or indirect base classes or interface.
            */

            Giraffe giraffe_A = new Giraffe();
            Giraffe giraffe_B = new Giraffe();

            giraffe_A = giraffe_B; // Always Okay because its the same type.

            // Implicit conversion to base type is safe.
            Animal giraffe_C = new Animal();
            giraffe_C = giraffe_A;

        }
    }

    class Animal
    {
        public void Eat(){ Console.WriteLine("Eating."); }
        public override string ToString(){ return "I am an animal"; }
    }

    class Giraffe : Animal { }
    class Elephant: Animal { }


}

namespace Explicit_Block
{
    class ConversionExplicit
    {
        public void Test1()
        {
            double x = 1234.7;
            int a;
            // Cast double to int
            a = (int) x;
            Console.Out.WriteLine("$$$ Explicit1 ... OUTPUT: " + a);

            Giraffe giraffe_A = new Giraffe();
            giraffe_A = testAnimal(giraffe_A);

        }

        public Giraffe testAnimal(Animal a)
        {
            /*
                Explicit conversion is required to cast back to derived type.
                Note:   This will compile but will throw an exception at run time
                        if the right side object is not in fact a giraffe.
            
             */
            Giraffe sameGiraffe = (Giraffe) a;
            return sameGiraffe;
        }
    }

    class Animal
    {
        public void Eat(){ Console.WriteLine("Eating."); }
        public override string ToString(){ return "I am an animal"; }
    }

    class Giraffe : Animal { }
    class Elephant: Animal { }



}
