﻿namespace Messages
{
    using NServiceBus;

    public class Ping : IMessage
    {
        public string Text { get; set; }
        public string Username { get; set; }
    }
}