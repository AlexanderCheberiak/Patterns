using System;

namespace Facade.Examples
{
    // Mainapp test application 
    class MainApp
    {
        public static void Main()
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            facade.MethodC();

            Console.Read();
        }
    }

    // Subsystem ClassA
    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("SubSystemOne Method");
        }
    }

    // Subsystem ClassB
    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("SubSystemTwo Method");
        }
    }

    // Subsystem ClassC
    class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("SubSystemThree Method");
        }
    }

    // Subsystem ClassD
    class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("SubSystemFour Method");
        }
    }

    // New Subsystem ClassE
    class SubSystemFive
    {
        public void MethodFive()
        {
            Console.WriteLine("SubSystemFive Method");
        }
    }

    // Facade
    class Facade
    {
        private SubSystemOne one;
        private SubSystemTwo two;
        private SubSystemThree three;
        private SubSystemFour four;
        private SubSystemFive five;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
            five = new SubSystemFive();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
            five.MethodFive();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            two.MethodTwo();
            three.MethodThree();
            five.MethodFive();
        }

        public void MethodC()
        {
            Console.WriteLine("\nMethodC() ---- ");
            one.MethodOne();
            three.MethodThree();
            four.MethodFour();
        }
    }
}
