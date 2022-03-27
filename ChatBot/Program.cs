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
            ChatBot3 insurance = new ChatBot3();
            GeneralChatBot general = new GeneralChatBot();

            new ConcreteMediator(car, house, insurance, general);

            Console.WriteLine("Chat Bot\r");
            Console.WriteLine("Enter \n 1 to ask about Car \n 2 to ask about House \n 3 to ask about Insurance \n 4 to Quit");
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
                case 3:
                    Console.WriteLine("Questions about Insurance\r");
                    insurance.InitializeKnownInsuranceResponses();
                    break;
                case 4:
                    Console.WriteLine("Thank you and See you next time!\r");
                    break;
            }          
        }
    }
}
