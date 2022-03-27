using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    internal class GeneralChatBot : BaseChatBot
    {
        List<string> respond = new List<string>();
        public void InitializeUnKnownResponses()
        {

            respond.Add("We have the best selection & prices, come on down");
            respond.Add("Happy to talk to you more in person about your question");
            Random rnd = new Random();
            int index = rnd.Next(respond.Count);
            Console.WriteLine(respond[index]);
        }
    }
}
