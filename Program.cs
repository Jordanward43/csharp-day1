using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Console.WriteLine("Hello User, what is your Name?");
            // string name = Console.ReadLine() .ToLower();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
             //Console.WriteLine("Hello" + name + ". It sounds like "+ "is" + age + "years old");
             //Console.WriteLine($"Hello {name}. It sounds like {name} is {age} years old.");

             //int myNum = 82;
             //myNum = myNum *2;
             //myNum *= 2;
             // Console.WriteLine(12 %2);
            //  if (name.ToLower()  == "jordan" && age == "25")
            //  {
            //      Console.WriteLine("YOU ROCK!"); //Truth

            //  }
            //  else
            //  {
            //      Console.WriteLine("Whazzzup!!!"); //False
            //  }
            //  else if(name.ToLower() == "zach") 
            //  {
            //      Console.WriteLine("wazzzup bossman!!!"); // if line 30 is true
            //  }
            //  else 
            //  {
            //      Console.WriteLine("Yo dawg I heard you like TV's");
            //  }

            //  switch (name.ToLower())
            //  {
            //      case "patrick":
            //         Console.WriteLine("you rock!");
            //         break;
            //      case "jordan":
            //      case "jake":
            //         Console.WriteLine("Yo bossman");
            //         if(name.ToLower() == "jake")
            //         {
            //             Console.WriteLine("good luck sleeping");
            //         }
            //         break;
            //      default:
            //         Console.WriteLine("I dont know you");
            //         break;
            //  }

            int intAge = 0;


            if(Int32.TryParse(age, out intAge))
            {
                if(intAge > 21)
                {
                Console.WriteLine("welcome to the club");
                }
                else
                {
                Console.WriteLine("go back to school kid");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            System.Console.WriteLine("Goodbye");

        }
    }
}
