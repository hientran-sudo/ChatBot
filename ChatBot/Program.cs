using System;
using ChatBot;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatBot1 car = new ChatBot1();
            ChatBot2 house = new ChatBot2();
            new ConcreteMediator(car,house);

            Console.WriteLine("Chat Bot\r");
            Console.WriteLine("Enter \n 1 for car \n 2 for house");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Questions about Car\r");
                    car.InitializeKnownCarResponses();
                    break;
                case 2:
                    Console.WriteLine("Questions about House\r");
                    house.InitializeKnownHouseResponses();
                    break;
            }          
        }
    }
}
