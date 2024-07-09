using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class UserAccountProxy : IUserAccount
    {
        private readonly UserAccount realUserAccount;
        string userRole;

        public UserAccountProxy(UserAccount userAccount, string userRole)
        {
            realUserAccount = userAccount;
            this.userRole = userRole;
        }

        public void AcceptFollowRequest()
        {
            if (userRole == "Admin" || userRole == "User")
                realUserAccount.AcceptFollowRequest();
            else
                Console.WriteLine("access denied");
        }

        public void SendFollowRequest(string senderId, string recieverId)
        {
            if (userRole == "Admin" || userRole == "User")
                realUserAccount.SendFollowRequest(senderId, recieverId);
            else
                Console.WriteLine("access denied");
        }

        public void SendMessage(string userId, string message)
        {
            if (userRole == "Admin" || userRole == "User")
                realUserAccount.SendMessage(userId, message);
            else
                Console.WriteLine("access denied");
        }
    }
}
