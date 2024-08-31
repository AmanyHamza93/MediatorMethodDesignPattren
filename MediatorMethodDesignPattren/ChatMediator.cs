using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMethodDesignPattren
{
    public class ChatMediator : IChatMediator
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(User sender, string message)
        {
            foreach (var user in users)
            {
                // Send message to all users except the sender
                if (user != sender)
                    user.ReceiveMessage(message);
            }
        }
    }
}
