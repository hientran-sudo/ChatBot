using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    internal class BaseChatBot
    {
        protected IMediator mediator;

        public BaseChatBot(IMediator med = null)
        {
            this.mediator = med;
        }

        public void SetMediator(IMediator med)
        {
            this.mediator = med;
        }
    }
}
