using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Crocodile : Animal, IRun, ISwim
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
            return "Я крокодил";
        }

        public override string WhoAmI()
        {
            return "Я могу плавать и бегать";
        }
    }
}
