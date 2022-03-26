using System;
using ChatBot;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatBot1 car = new ChatBot1();
            new ConcreteMediator(car);
            Console.WriteLine("Chat Bot\r");
            Console.WriteLine("Questions about car? Put 1 as YES and O as NO");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {                
                car.InitializeKnownCarResponses();
            }            
        }
    }
}
