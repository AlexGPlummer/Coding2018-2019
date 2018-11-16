using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creation_Save_Load
{
    class Character
    {
        public string name;
        public int lives;
        public int health;
        public int strength;
        public int speed;
        public int hunger;
        public Character(string name, int lives, int health, int strength, int speed, int hunger)
        {
            this.name = name;
        }
    }    
}
