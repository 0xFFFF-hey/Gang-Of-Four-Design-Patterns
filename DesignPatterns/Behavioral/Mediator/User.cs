using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    // colleague
    internal class User
    {
        public string Name { get; }
        private IChatRoomMediator _chatRoom;

        public User(string name)
        {
            Name = name;
        }

        public void SetChatRoom(IChatRoomMediator chatRoom)
        {
            _chatRoom = chatRoom;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            _chatRoom.SendMessage(message, this);
        }

        public void ReceiveMessage(string message, string sender)
        {
            Console.WriteLine($"{Name} receives message from {sender}: {message}");
        }
    }
}
