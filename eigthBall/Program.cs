using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace eigthBall
{
    class Program
    {
        private static Random randomObject = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Type (..quit..) to exit");
            Console.WriteLine();
            ConsoleColor oldColor = Console.ForegroundColor;
            
            //enfainte whiel loop
            while(true)
            {
                string userQuestion = getQuestion();
                //if nothhing is entered by the user
                if (userQuestion.Length == 0)
                {
                    Console.WriteLine("You need to ask a question...\n");
                    continue;//next itteration og loop
                }
                //if the user types quit
                if (userQuestion.ToLower().Equals("quit"))
                {
                    break;//jump out of the loop
                }
                //call functions
                computerThinking();
                computerAnswer();
            }
           //restore users text color
         //  Console.ForegroundColor = oldColor;
        }
        /// <summary>
        /// method to ask a user a question, also sets the text color
        /// </summary>
        /// <returns>users Question</returns>
        private static string getQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Ask a Question: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string userQuestion = Console.ReadLine();

            return userQuestion;
        }
        /// <summary>
        /// method the make the computer look as though it is thinking about the anwser
        /// </summary>
        private static void computerThinking()
        {
            Console.Write("Please wait");
            int sleepTime = randomObject.Next(5) + 1;

            int count = 0;
            while (count <= sleepTime)
            {
                Thread.Sleep(500);
                Console.Write(".");
                count++;
            }
        }
        /// <summary>
        /// method for diffrent anwser option given by the program
        /// </summary>
        private static void computerAnswer()
        {
            int randNum = randomObject.Next(4)+1;

                switch (randNum)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("YES!\n");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("NO!\n");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("OMG YES!\n");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HELL NO!\n");
                        break;
                }
        }


    }
}
