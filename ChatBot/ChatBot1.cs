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
        public void InitializeKnownCarResponses()
        {
            Hashtable table = new Hashtable();           
            table.Add("Guarantee?", "Sure - it's in the fine print of our contract");
            table.Add("Financing?", "Louie the loan shark will be happy to work with you");

            this.mediator.Process(table);

           
        }
        public void InitializeUnKnownCarResponses()
        {
            

        }
    }
}
