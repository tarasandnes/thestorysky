// C# is a static typed language which means you have tio declare avariables type and it cannot change during the lifetime of the variable


// BK stuff that's greyed out here means stuff from package not being used - use reshaper alt enter then can remove
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Classes (related) in namespaces - Namespaces in assemblies (DLLs etc..) - DLLs in/part of APP
namespace TheStorySky
{


    // Access modifier simply states who can acccess what
    public class Program
    {
        static void Main(string[] args)
        {

            // ----------------------- Some BOOL shit
            bool isTall = true; // try use is or has before variable name for bools
            Console.WriteLine("Is Kendall tall? " + isTall);

            //------------------------ Some convert shit
            byte myByte = 1;
            int myInt = Convert.ToInt32(myByte); // You can use things like Int.Parse(bla bla) but a useful class is also the COnvert class

            Console.WriteLine("My converted byte to an int is " + myInt);

            Console.WriteLine("Press any key to start this fucking app");
            Console.ReadKey();
            Console.WriteLine("Fuck you world");
            Console.Beep(440, 4000);

            //------------------------- using Calculator class below - example opf static one place class
            int result = Calculator.Add(1, 2);
            Console.WriteLine("Adding the two numbers produced: " + result);

            //------------------------- Using Person class
            var person = new Person(); // note use if var here. Redundant to to do "Person person = new Person();
            person.FirstName = "Kendall";
            person.LastName = "Reid";
            person.Introduce();

            Console.WriteLine("Now you can DRUK any key and go fuck yourself, that is, piss off bye");
            Console.ReadLine();

        }


    }
}


// When it comes to comments, comments should not explain what the code is doing, it should be obvious from reading the code
// Comments are there to explain why's, how;s, constraints, and so on. NEVER "whats"