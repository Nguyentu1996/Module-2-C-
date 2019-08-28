using System;
using System.Collections.Generic;
using System.Text;

namespace FootBallManagementSystem
{
    class Player : IPlayer
    {
        private string name;
        private int age;
        private int attack;
        private int defense;
        private int stamina;
        private int speed;
        private int power;
     
        public string Name { get => name; set =>  name = value; }

        public int Age{ get => age;  }
        public void SetAge(int age)
        {
            if (age > 0 && age < 40)
            {
                this.age = age;
            }
        }
        public int Attack { get => attack; set => attack = value; }
        public int Defense { get => defense; set => defense = value; }
        public int Stamina { get => stamina; set => stamina = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Power { get => power; set => power = value; }
        public int Atatack { get => attack; set => attack=value; }  

        public void getInfo()
        {
            Console.WriteLine("Name :{0} , Age : {1} , average : {2}",Name,Age,((Attack+Defense+Stamina+Speed+Power)/5));
        }
    }
}
