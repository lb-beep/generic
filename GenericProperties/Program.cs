using System;
using System.Collections.Generic;

namespace GenericProperties
{
    class Program
    {
        static void Main(string[] args)
        {
           

            TheClass<string> myClass = new TheClass<string>();
            myClass.ClassName = "The class name is C charp";
            myClass.ClassProperty = "Get to class";
            

            Console.WriteLine("The class name is: " + myClass.ClassName +
                                      "Please: " + myClass.ClassProperty);

            TheClass<string> myClass2 = new TheClass<string>();
            myClass2.ClassProperty = "Get to class";
            myClass2.ClassName = "Xcode is coming up!";

            Console.WriteLine("My next class is: " + myClass2.ClassName +
                                     "Please" + myClass2.ClassProperty);

        }
    }
}
public class TheClass<T>
{
    public T ClassProperty { get; set; }
    public string ClassName { get; set; }

    
}

