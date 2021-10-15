using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Shlepa : Animal, IRun
    {
        public string Run()
        {
            return "Я бегу";
        }

        public override string WhatICan()
        {
            return "Я БОЛЬШОЙ РУССКИЙ КОТ";
        }

        public override string WhoAmI()
        {
            return "Я могу бегать";
        }
    }
}
