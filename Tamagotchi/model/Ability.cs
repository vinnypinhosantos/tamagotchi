using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.model
{
    public class Ability
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name.ToUpper();
        }
    }
}
