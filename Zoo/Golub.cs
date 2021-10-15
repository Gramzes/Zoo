using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Golub : Animal, IFly
    {
        public string Fly()
        {
            return "Я лечу";
        }

        public override string WhatICan()
        {
            return "Я голубь";
        }

        public override string WhoAmI()
        {
            return "Я могу летать";
        }
    }
}
