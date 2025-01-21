using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    internal class ChatRoom : IChatRoomMediator
    {
        private readonly Dictionary<string, User> _users = new Dictionary<string, User>();

        public void RegisterUser(User user)
        {
            if (!_users.ContainsKey(user.Name))
            {
                _users[user.Name] = user;
                user.SetChatRoom(this);
            }
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users.Values)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message, sender.Name);
                }
            }
        }
    }
}
