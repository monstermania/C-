using System;
//tells you the application name
namespace ConsoleApp3

{

    // class fabricio{
    //    public static string name = "name :coffeeffee";
    //    public static string favoriteDrink = "coffee";
    //    private static string lastname = "last name :I Don't Have One";
    //    public static int age =  22;
    //}

        //color u do Console.ForegroundColor = ConsoleColor.white
        // alert in c# console is like
        //Console.write("Ask aquestion:")
        // kinda like a prompt
        //Console.ReadLine();
    // a class kind of like a blue print for your application
    class Program
    {
        //void haere mecause this is the main function which does not return anything. static is there so you dont habe to call  the function whit and object or class
        static void Main(string[] args)
         {

            //It is simple it writes a line without a response
            Console.WriteLine("Made by Zeeshan Asad");
            //the new part in thsi line of code makes this an object. the c# library gives a class called random which creates a random number generator.
            Random randomObject = new Random();
            
            // runs for everrrrrr and evvvverr 
            while (true){
                Console.Write("Ask a question:");

                //question string stores the line that I am on. 
                string questionString = Console.ReadLine();
                if( questionString.ToLower() == "quit")
               // Console.Write("Ask a question:");
                Console.Write("");
                // get a random #
                int randomNumber = randomObject.Next(4);
                //the switch statement is often used as an alternast three or more conditions0.tive to an if-else construct if a single expression is tested again
                // Use random number to determine a respone 
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("Yes");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("No");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("HELL NO");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("OMG Yes!");
                            break;
                        }

                }
            }


        }
    }
}
