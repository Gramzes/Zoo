using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Shuka : Animal, ISwim
    {
        public string Swim()
        {
            return "Я плыву";
        }

        public override string WhatICan()
        {
            return "Я щука"; 
        }

        public override string WhoAmI()
        {
            return "Я могу плавать";
        }
    }
}
