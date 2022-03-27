using System;
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
