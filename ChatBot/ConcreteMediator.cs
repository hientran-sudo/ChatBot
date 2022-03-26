using System;
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
        public ConcreteMediator(ChatBot1 car)
        {
            this._car = car;
            this._car.SetMediator(this);
            
        }

        public void Process(Hashtable table)
        {
            Console.WriteLine("Guarantee? Put 1 to ask");
            int answer = Convert.ToInt32(Console.ReadLine());
            foreach (DictionaryEntry item in table)
            {
                if (item.Key.Equals("Guarantee?"))
                Console.WriteLine($"{item.Value}");
            }
        }

    }
}
