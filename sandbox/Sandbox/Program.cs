using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle();

        myCircle._radius = 10;

        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }
} 
    // static double AddNumbers(double x, int y)
    // {
    //     return x + y;
    // }

    // static string MyName()
    // {
    //     return "Bob";
    // }

    // static void DisplayGreeting(string name)
    // {
    //     Console.WriteLine($"Welcome {name}, its nice to meet you");
    // }

    // static void Main(string[] args)
    // {

    //     string myName = MyName();
    //     DisplayGreeting(myName);
    //     double total = AddNumbers(12.234, 20);
    //     Console.WriteLine(total);

        // int x = 10;
        // int y = 30;
        // int z = 40;
        // if ((x == 10 || y == 30) && z == 40)
        // {
        //     Console.WriteLine("x is 10");
        //     Console.WriteLine("y is fun");
        // }
        // else if (x == 20)
        // {
        //     Console.WriteLine("x is 20");
        // }
        // else
        // {
        //     Console.WriteLine("Default output");
        // }

        // string numberString = "123";
        // int myNumber = int.Parse(numberString);



        //// While Loop

        // bool done = false;
        // while (! done)
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine() == "y";
        // }



        //// Do-While Loop

        // bool done;
        // do
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine().ToLower() == "y";
        // } while (! done);



        //// For Loop
        
        // for(int i = 1000000; i > -100000; i -= 5000)
        // {
        //     Console.WriteLine(i);
        // }



        //// Lists List<int> = new List<int>()

        // List<string> myFriends = new List<string> {"Bob", "Betty", "Bubba"};

        // myFriends.Add("Doug");

        // foreach(string friend in myFriends)
        // {
        //     Console.WriteLine(friend);
        // }
        

        
        //// Functions
        
        

//     }
// }