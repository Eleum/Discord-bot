using DiscordBot.Discord;
using DiscordBot.Discord.Entity;
using System;

namespace DiscordBot
{
    class Program
    {
        public static void Main(string[] args)
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello World!");

            var config = new BotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
        }
    }
}
