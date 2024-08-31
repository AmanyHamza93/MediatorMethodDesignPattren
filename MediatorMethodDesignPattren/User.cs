using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMethodDesignPattren
{
    public class User
    {
        private IChatMediator mediator;
        public string Name { get; }

        public User(IChatMediator mediator, string name)
        {
            this.mediator = mediator;
            Name = name;
            mediator.AddUser(this);
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{ Name} sends: { message} ");
            mediator.SendMessage(this, message);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($" { Name} receives: { message}");
        }
    }
}
