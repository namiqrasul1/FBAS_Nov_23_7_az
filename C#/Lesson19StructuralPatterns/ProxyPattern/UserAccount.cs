using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class UserAccount : IUserAccount
    {
        public void AcceptFollowRequest()
        {
            Console.WriteLine("Follow request accepted");
        }

        public void SendFollowRequest(string senderId, string recieverId)
        {
            Console.WriteLine($"{senderId} requested friendship to {recieverId}");
        }

        public void SendMessage(string userId, string message)
        {
            Console.WriteLine($"{userId} sent message: {message}");

        }
    }
}
