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
        public void InitializeKnownHouseResponses()
        {
            table.Add("Year Built?", "It's 2021");
            table.Add("Satety?", "Yes - it's in the safe neighborhood nearby Fairfield U");
            table.Add("Property type?", "It's a house");
            table.Add("How many squarefeets", "It's 4,000 sqrts");
            table.Add("Price?", "It's $850,000");
            table.Add("How many bedrooms?", "It's 5 bedrooms");
            table.Add("How many bathrooms?", "It's 4.5 bathrooms");          
            table.Add("Is A/C included?", "Yes - it is");
            table.Add("Is swimming pool included?", "Yes - it is");
            table.Add("Insurance?", "Yes - it's covered in our contract");          

            this.mediator.Process(this, table);
        }
    }
}

