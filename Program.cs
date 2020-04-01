using System;
namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            myClass2 myclass = new myClass2("Bent","hejvej2","Nykøbing sj");
            myClass2 myClass1 = new myClass2("Børge","hejvej2","Nykøbing sj");
            myClass2 myClass2 = new myClass2("Lasse","hejvej2","Nykøbing sj");
        }
    }
}
