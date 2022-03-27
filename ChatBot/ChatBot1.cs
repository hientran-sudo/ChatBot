﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    internal class ChatBot1 : BaseChatBot
    {
        Hashtable table = new Hashtable();
        
        public void InitializeKnownCarResponses()
        {
            table.Add("Car Model?", "2022 A 220 4MATIC Sedan");
            table.Add("Price?", "It's $35,950");
            table.Add("Engine?", "2.0L inline-4 turbo");
            table.Add("Acceleration?", "7.1 sec 0-60 mph");
            table.Add("City fuel economy?", "25 mpg");
            table.Add("Highway fuel economy?", "35 mpg");
            table.Add("Passenger capacity?", "It's 5");
            table.Add("Cargo capacity?", "8.6 cu ft");
            table.Add("Guarantee?", "Sure - it's in the fine print of our contract");
            table.Add("Financing?", "Louie the loan shark will be happy to work with you");

            this.mediator.Process(this, table);
        }
        //public void InitializeUnKnownCarResponses()
        //{
            
        //    respond.Add("We have the best selection & prices, come on down");
        //    respond.Add("Happy to talk to you more in person about your question");
        //    Random rnd = new Random();
        //    int index = rnd.Next(respond.Count);
        //    Console.WriteLine(respond[index]);
        //}
    }
}
