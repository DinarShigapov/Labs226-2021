﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Mage: Unit
    {
        public Mage(int str, int dex, int con, int intl)
        {
            base.Str = str;
            base.Dex = dex;
            base.Con = con;
            base.Intl = intl;
        }
    }
}