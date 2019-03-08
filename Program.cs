using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesserExecise
{//ny
    class Program
    {
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
        const int MaxTrials = 10;

        static void Main(string[] args)
        {
            string answer = "Unicorn";
            int tryNumber = 10;
            string almostAnswer = "unicorn";
            string tryIt;

            /* TO DO: here is where you add your code! */
            Console.WriteLine("Guess what im thinking :)");
            Console.WriteLine("You have 10 tries");
            Console.WriteLine("Hint: It is a single word and not a number");

            //1. forsøg
            tryIt = Console.ReadLine();
            winCheck();
            tryNumber = tryNumber - 1;
            Console.WriteLine("Nope that was wrong try again");
            Console.WriteLine("You now have " + tryNumber + " tries left");
            aAnswer();

            //2. forsøg
            tryIt = Console.ReadLine();
            winCheck();

            tryNumber = tryNumber - 1;
            Console.WriteLine("Nah you are wrong again");
            Console.WriteLine("You now have " + tryNumber + " tries left");
            aAnswer();

            //3. forsøg
            tryIt = Console.ReadLine();
            winCheck();

            tryNumber = tryNumber - 1;
            Console.WriteLine("Still wrong");
            Console.WriteLine("You now have " + tryNumber + " tries left" + "Hint: It is an animal");
            Console.WriteLine("Hint: It is an animal");
            aAnswer();

            //4. forsøg
            tryIt = Console.ReadLine();
            winCheck();

            tryNumber = tryNumber - 1;
            Console.WriteLine("No!");
            Console.WriteLine("You now have " + tryNumber + " tries left");
            aAnswer();

            //5.forsøg
            tryIt = Console.ReadLine();
            winCheck();

            tryNumber = tryNumber - 1;
            Console.WriteLine("Maybe you should stop while it is fun");
            Console.WriteLine("You now have " + tryNumber + " tries left");
            Console.WriteLine("It is my favorite animal");
            aAnswer();

            //6.forsøg
            tryIt = Console.ReadLine();
            winCheck();

            tryNumber = tryNumber - 1;
            Console.WriteLine("Could you please get it rigth?");
            Console.WriteLine("You now have " + tryNumber + " tries left");
            aAnswer();

            //7. forsøg
            tryIt = Console.ReadLine();
            winCheck();

            tryNumber = tryNumber - 1;
            Console.WriteLine("Now it is getting embarrassing");
            Console.WriteLine("You now have " + tryNumber + " tries left");
            aAnswer();

            //8. forsøg
            tryIt = Console.ReadLine();
            winCheck();

            tryNumber = tryNumber - 1;
            Console.WriteLine("Wow nope not that either");
            Console.WriteLine("You now have " + tryNumber + " tries left");
            aAnswer();

            //9. forsøg
            tryIt = Console.ReadLine();
            winCheck();

            tryNumber = tryNumber - 1;
            Console.WriteLine("Wrong again");
            Console.WriteLine("You now have " + tryNumber + " tries left");
            Console.WriteLine("It is the national animal of a country in the UK");
            aAnswer();

            //10. forsøg
            tryIt = Console.ReadLine();
            winCheck();

            tryNumber = tryNumber - 1;
            Console.WriteLine("Nah you are wrong again");
            Console.WriteLine("You now have " + tryNumber + " tries left");

            Console.ReadLine();

            void winCheck()
            {
                if (tryIt == answer)
                {
                    Console.WriteLine("You gussed it my friend");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            void aAnswer()
            {
                if (tryIt == almostAnswer)
                    Console.WriteLine("Try with a casp letter");
            }

        }
    }
}
