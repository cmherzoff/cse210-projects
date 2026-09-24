using System;

class Program
{
    static void Main(string[] args)
    {
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

        List<string> myFriends = new List<string> {"Bob", "Betty", "Bubba"};

        myFriends.Add("Doug");

        foreach(string friend in myFriends)
        {
            Console.WriteLine(friend);
        }
        

        
        //// Functions
        
    }
}