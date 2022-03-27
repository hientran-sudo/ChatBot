using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    internal class ChatBot3 : BaseChatBot
    {
        Hashtable table = new Hashtable();
        public void InitializeKnownInsuranceResponses()
        {
            table.Add("Insurance Type?", "It's Health Insurance");
            table.Add("Coverage Time?", "It will cover for 1 year");
            table.Add("Rate?", "It's $1200 in total");
            table.Add("Can I pay monthly?", "Yes - you can! It's $120 per month");
            table.Add("Is tax included?", "No - it isn't");
            table.Add("Is dental care included", "Yes - it is");
            table.Add("Is vision care included", "Yes - it is");
            table.Add("Is dermatologist included", "No - it isn't");
            table.Add("Is PTO included?", "Yes - it is");
            table.Add("Renew automatically?", "Yes - it is");
            
            this.mediator.Process(this, table);
        }
    }
}
