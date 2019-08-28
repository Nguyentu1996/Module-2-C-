using System;
using System.Collections.Generic;
using System.Text;

namespace FootBallManagementSystem
{
    interface IPlayer
    {
        string Name { get; set; }
        int Age { get; }
        int Atatack { get; set; }
        int Defense { get; set; }
        int Stamina { get; set; }
        int Speed { get; set; }
        int Power { get; set; }
        void getInfo();
    }
}
