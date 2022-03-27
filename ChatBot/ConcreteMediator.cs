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
            int answer;
            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine($"Q: {item.Key} (Enter any number on the keyboard - to ask AI Assistant this question)");
                answer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A: {item.Value} \n");
                Console.WriteLine("Does that answer your question? \nEnter \n any number on the keyboard as Yes and to Continue \n 0 as No and to Quit");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 0)
                {
                    this._general.InitializeUnKnownResponses();
                    Console.WriteLine("See You Next Time!");
                    break;
                }

            }          
        }
    }
}
