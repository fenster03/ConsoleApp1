using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IHashProvider
    {
        string Hash(string key);
    }

    public class HashProvider : IHashProvider
    {
        public string Hash(string key)
        {
            return HashUtility.MD5Hash(key);
        }
    }
}
