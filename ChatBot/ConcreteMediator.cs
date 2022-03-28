using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    internal class ConcreteMediator : IMediator
    {
        private ChatBot1 _car;
        private ChatBot2 _house;
        private ChatBot3 _insurance;
        private GeneralChatBot _general;
        public ConcreteMediator(ChatBot1 car, ChatBot2 house, ChatBot3 insurance, GeneralChatBot general)
        {
            this._car = car;
            this._house = house;
            this._insurance = insurance;
            this._general = general;

            this._car.SetMediator(this);
            this._house.SetMediator(this);
            this._insurance.SetMediator(this);
            this._general.SetMediator(this);
        }

        public void Process(object sender, Hashtable table)
        {
            char answer;

            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine($"\nQ: {item.Key} \n(!) Enter \n 'y' - to ask that question OR \n 'n' - to ask another question");
                Console.WriteLine("-->Your Input: ");
                answer = Console.ReadKey().KeyChar;
                if (answer == 'y')
                {
                    Console.WriteLine($"\nA: {item.Value} \n");
                    Console.WriteLine("(?) Does that answer your question? \n(!) Enter \n 'y' as Yes and to Continue OR \n 'n' as No and to Quit the Chat");
                    Console.WriteLine("-->Your Input: ");
                    answer = Console.ReadKey().KeyChar;
                    if (answer == 'n')
                    {
                        Console.WriteLine("\n-----------Chat is Ended-----------");
                        this._general.InitializeUnKnownResponses();
                        Console.WriteLine("(!) Back to Main Menu\n");
                        break;
                    }
                }
                else if (answer == 'n')
                {
                    Console.WriteLine("\n(!) Let's try another question\n");
                }
                else
                {
                    Console.WriteLine("\n(!) Please enter a Correct Input\n");
                    break;
                }
            }
        }
    }
}