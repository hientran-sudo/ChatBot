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
        public void InitializeKnownHouseResponses()
        {
            Hashtable table = new Hashtable();
            table.Add("Insurance?", "Yes - it's covered our contract");
            table.Add("Safety", "Yes - it's in the safe neighborhood");

            this.mediator.Process(table);


        }
        public void InitializeUnKnownHouseResponses()
        {


        }
    }
}
