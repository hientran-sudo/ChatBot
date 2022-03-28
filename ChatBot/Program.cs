using System;
using ChatBot;

namespace ChatBot
{
    class Program
    {
        public static void MainMenu()
        {           
            Console.WriteLine("-----------Main Menu-----------");
            Console.WriteLine("Enter \n 1 - to ask about Car \n 2 - to ask about House \n 3 - to ask about Insurance \n 4 - to Quit");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Welcome to Chat Bot"));
            int option;
            ChatBot1 car = new ChatBot1();
            ChatBot2 house = new ChatBot2();
            ChatBot3 insurance = new ChatBot3();
            GeneralChatBot general = new GeneralChatBot();

            new ConcreteMediator(car, house, insurance, general);

            do
            {
                MainMenu();
                Console.WriteLine("Your Input: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("-----------Questions about Car-----------\n");
                        car.InitializeKnownCarResponses();

                        break;
                    case 2:
                        Console.WriteLine("-----------Questions about House-----------\n");
                        house.InitializeKnownHouseResponses();
                        break;
                    case 3:
                        Console.WriteLine("-----------Questions about Insurance-----------\n");
                        insurance.InitializeKnownInsuranceResponses();
                        break;
                    case 4:
                        Console.WriteLine("Thank you and See you next time!\r");
                        break;
                }
            }
            while (option != 4);
        }
    }
}
