using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    internal class ChatBot2 : BaseChatBot
    {
        Hashtable table = new Hashtable();
        List<string> respond = new List<string>();
        public void InitializeKnownHouseResponses()
        {
            table.Add("Insurance?", "Yes - it's covered our contract");
            table.Add("Safety", "Yes - it's in the safe neighborhood");

            this.mediator.Process(this, table);
        }


    }
        //public void InitializeUnKnownHouseResponses()
        //{
        //    respond.Add("We have the best selection & prices, come on down");
        //    respond.Add("Happy to talk to you more in person about your question");
        //    Random rnd = new Random();
        //    int index = rnd.Next(respond.Count);
        //    Console.WriteLine(respond[index]);

        //}
   }

