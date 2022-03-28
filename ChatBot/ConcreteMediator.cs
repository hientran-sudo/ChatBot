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
            //foreach (DictionaryEntry item in table)
            //{
            //    Console.WriteLine($"\nQ: {item.Key} (Enter 'Y' - to ask AI Assistant this question OR 'N' to Quit )");
            //    Console.WriteLine("Your Input: ");
            //    answer = Console.ReadKey().KeyChar;
            //    Console.WriteLine($"\nA: {item.Value} \n");

            //    Console.WriteLine("Does that answer your question? \nEnter \n 'Y' as Yes and to Continue \n 'N' as No and to Quit");
            //    Console.WriteLine("Your Input: ");
            //    answer = Console.ReadKey().KeyChar;
            //    if (answer == 'N')
            //    {
            //        this._general.InitializeUnKnownResponses();
            //        Console.WriteLine(">> Back to Main Menu\n");
            //        break;
            //    }               
            //}
            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine($"\nQ: {item.Key} \n(!) Enter \n 'y' - to ask AI Assistant that question OR \n 'n' - to Quit");
                Console.WriteLine("-->Your Input: ");
                answer = Console.ReadKey().KeyChar;
                if (answer == 'y')
                {
                    Console.WriteLine($"\nA: {item.Value} \n");
                    Console.WriteLine("(?) Does that answer your question? \n(!) Enter \n 'y' as Yes and to Continue OR \n 'n' as No and to Quit");
                    Console.WriteLine("-->Your Input: ");
                    answer = Console.ReadKey().KeyChar;
                }               
                else if (answer == 'n')
                {
                    Console.WriteLine("\n-----------Chat is Ended-----------");
                    this._general.InitializeUnKnownResponses();
                    Console.WriteLine("(!) Back to Main Menu\n");
                    break;
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