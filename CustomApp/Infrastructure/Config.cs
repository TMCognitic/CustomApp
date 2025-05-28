using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomApp.Infrastructure
{
    public class Config
    {
        public string Option1 { get; }
        public int Option2 { get; }

        public Config(string option1, int option2)
        {
            Option1 = option1;
            Option2 = option2;
        }
    }
}
