using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        public int points;
        public Character(string name, int lives, int health, int strength, int speed, int hunger, int points)
        {
            this.name = name;
            this.lives = lives;
            this.health = health;
            this.strength = strength;
            this.speed = speed;
            this.hunger = hunger;
            this.points = points;
        }        
    }    
}
