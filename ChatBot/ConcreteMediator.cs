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
        private GeneralChatBot _general;
        public ConcreteMediator(ChatBot1 car, ChatBot2 house, GeneralChatBot general)
        {
            this._car = car;
            this._house = house;
            this._general = general;

            this._car.SetMediator(this);
            this._house.SetMediator(this);
            this._general.SetMediator(this);
        }

        public void Process(Hashtable table, List<string> respond)
        {
            int answer;
            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine($"{item.Key} Enter 1 to ask");
                answer = Convert.ToInt32(Console.ReadLine());
                if (item.Key.Equals($"{item.Key}"))
                {
                    Console.WriteLine($"{item.Value}");
                    Console.WriteLine("Does that answer your question? Enter \n 1 as Yes \n 0 as No");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 0)
                    {
                        this._general.InitializeUnKnownResponses();
                    }
                }              
            }           
        }
    }
}
