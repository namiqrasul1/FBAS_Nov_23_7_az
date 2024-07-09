using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal interface IUserAccount
    {
        void SendMessage(string userId,string message);
        void SendFollowRequest(string senderId, string recieverId);
        void AcceptFollowRequest();
    }
}
