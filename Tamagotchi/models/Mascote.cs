using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.models
{
    public class Mascote
    {
        public List<Ability> abilities {get; set;}
        private string _name;
        public string Name { 
            get 
            { 
                return _name; 
            } 
            set 
            { 
                _name = value; 
            } 
        }

        private double _height;
        public double Height
        {
            get 
            { 
                return _height; 
            }
            set
            {
                _height = value;
            }
        }
        
        private double _weight;
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }
        public Mascote(string name, double height, double weight) 
        {
            Name = name;
            Height = height;
            Weight = weight;
            abilities = new List<Ability>();
        }

        public override string ToString() 
        { 
            return "Nome: " + Name + "/n" + "Height: " + Height + "/n" + "Weight: " + Weight;
        }

    }
}
