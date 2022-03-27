﻿using System;
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
                Console.WriteLine($"{item.Key} Enter 1 to ask");
                answer = Convert.ToInt32(Console.ReadLine());
                if (item.Key.Equals($"{item.Key}"))
                {
                    Console.WriteLine($"--> {item.Value} \n");
                    Console.WriteLine("Does that answer your question? \nEnter \n 1 as Yes and to Continue \n 0 as No and to Quit");
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
