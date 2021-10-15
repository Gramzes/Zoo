using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Medved : Animal, IRun, ISwim
    {
        public string Run()
        {
            return "Я бегу";
        }

        public string Swim()
        {
            return "Я плыву";
        }

        public override string WhatICan()
        {
            return "Я медведь"; 
        }

        public override string WhoAmI()
        {
            return "Я могу бегать и плавать"; 
        }
    }
}
