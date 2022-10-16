using System;

namespace AbstractClassAndMethod
{
    //Abstract class is a special type of class
    //that is created strictly to be a base class
    //for other classes to derive from
    //they cannot be instantiated
    //abstract class may have fields,properties and methods jus like any other classes.
    //However they cannot have static members
    //Abstract classes can a have special type of method known as abstract methods 

    //abstract methods are methods that have no body and MUST be implemented in the derived class.
    //they can only exist in abstract classes
    //Abstract method is like contract,
    //if you want to ensure that any class that inherits your class implements a certain method,
    //you can declare the class as an abstract class and the method as an abstract method


    class Program
    {
        abstract class MyAbstractClass
        {
            private readonly string _message = "Hello C#";

            public void PrintMessage()
            {
                Console.WriteLine(_message);
            }

            public abstract void PrintMessageAbstract();
        }

        class ClassA : MyAbstractClass
        {
            public override void PrintMessageAbstract()
            {
                Console.WriteLine("C# is fun!");
            }
        }
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            Console.WriteLine("\nMessage From BaseClass_MyAbstarctClass" + 
                              "\n*******************************************");
            a.PrintMessage();
            Console.WriteLine("\nMessage From DerivedClass_ClassA" + 
                              "\n**********************************************");
            a.PrintMessageAbstract();

            //Note
            //We can not instantiate abstract class "MyAbstractClass abClass = new MyAbstractClass()"
            //this will bring error

            //We can only Instantiate derived class "ClassA a = new ClassA()
        }
    }
}
