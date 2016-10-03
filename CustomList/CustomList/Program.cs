using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            BetterList<string> customers = new BetterList<string>() {"this","string"};
            customers.Add("hello");
            
        }
    }
}
