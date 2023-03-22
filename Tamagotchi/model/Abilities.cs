using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.model
{
    public class Abilities
    {
        public Ability ability { get; set; }
        public bool is_hidden { get; set; }
        public override string ToString()
        {
            return ability.ToString();
        }
    }
}
