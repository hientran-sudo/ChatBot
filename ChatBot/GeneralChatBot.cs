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
        public GeneralChatBot()
        {
            respond.Add("We have the best selections & prices, come on down");
            respond.Add("Happy to talk to you more in person about your question");
            respond.Add("It's okay! We can help you more in person");
            respond.Add("We apologize that our AI assistant could not answer your questions");
            respond.Add("We apologize that our AI assistant could not address your concerns");
            respond.Add("Please feel free to contact us at 203-999-888 for further assistance");
            respond.Add("We are happy to assist you today");
            respond.Add("It's our pleasure to chat with you today");
            respond.Add("We are trying our best to deliver a better service to all of our customers");
            respond.Add("Crap! AI could not assist you in this regard!");
        }
        public void InitializeUnKnownResponses()
        {
            Random rnd = new Random();
            int index = rnd.Next(respond.Count);
            Console.WriteLine("\n" + respond[index]);
        }
    }
}
