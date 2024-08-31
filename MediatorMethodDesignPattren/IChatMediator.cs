using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMethodDesignPattren
{
    public interface IChatMediator
    {
        void AddUser(User user);
        void SendMessage(User sender, string message);
    }
}
