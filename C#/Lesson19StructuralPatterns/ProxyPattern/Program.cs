using ProxyPattern;

UserAccountProxy proxy = new UserAccountProxy(new UserAccount(), "Guest");

proxy.SendFollowRequest("2", "4");
proxy.AcceptFollowRequest();
proxy.SendMessage("2", "salam ");