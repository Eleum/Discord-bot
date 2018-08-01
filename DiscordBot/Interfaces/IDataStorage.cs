using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordBot.Interfaces
{
    public interface IDataStorage
    {
        void StoreObject(object obj, string key);

        T GetObject<T>(string key);
    }
}
