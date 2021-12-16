﻿using System.Collections.Generic;
using System.Text;
using System;

namespace Labs226_2021.Div
{
  
        public class Mage : Charter
        {
            public double CritdamagP
            {
                get => _critdamag;
                set
                {
                    _critdamag = DamagP * (2 + Dex * 0.05);
                }
            }
            public double CritdamagM
            {
                get => _critdamag;
                set
                {
                    _critdamag = DamagM * (2 + Int * 0.15);
                }
            }
            public double CritCgantM
            {
                get => _critChanse;
                set
                {
                    _critChanse = 20 + Int * 0.1;
                }
            }
            public double CritCgantP
            {
                get => _critChanse;
                set
                {
                    _critChanse = 20 + Dex * 0.3;
                }
            }
            public double Str
            {
                get => _str;
                set
                {
                    if (value > 45 & value < 15)
                    {
                        _str = value;
                    }
                    else
                    if (value < 15)
                    {
                        _str = 15;

                    }
                    else
                    {
                        _str = 45;
                    }
                }
            }
            public double Dex
            {
                get => _dex;
                set
                {
                    if (value > 80 & value < 20)
                    {
                        _dex = value;
                    }
                    else
                    if (value < 20)
                    {
                        _dex = 20;

                    }
                    else
                    {
                        _dex = 80;
                    }
                }
            }
            public double Con
            {
                get => _con;
                set
                {
                    if (value > 70 & value < 15)
                    {
                        _con = value;
                    }
                    else
                    if (value < 15)
                    {
                        _con = 15;

                    }
                    else
                    {
                        _con = 70;
                    }
                }
            }
            public double Int
            {
                get => _int;
                set
                {
                    if (value > 250 & value < 35)
                    {
                        _int = value;
                    }
                    else
                    if (value < 35)
                    {
                        _int = 35;

                    }
                    else
                    {
                        _int = 250;
                    }
                }
            }
            public double DamagM
            {
                get => _damag;
                set
                {
                    value = Int * 0.2 + Int / 10;
                    _damag = value;
                }

            }
            public double DefenseM
            {
                get => _def;
                set
                {
                    value = Int * 0.3;
                    _def = value;
                }
            }
            public double DamagP
            {
                get => _damag;
                set
                {
                    value = Str * 0.2 + Dex * 0.2;
                    _damag = value;
                }

            }
            public double DefenseP
            {
                get => _def;
                set
                {
                    value = Dex * 0.1 + Con * 0.2;
                    _def = value;
                }
            }
            public double Healing
            {
                get => _healing;
                set
                {
                    if (Mana < Int * 2)
                    {
                        _healing -= (1.5 * Con + 0.5 * Str) * 0.2;
                    }
                    else
                    {
                        _healing = 1.5 * Con + 0.5 * Str;
                    }
                    if ((1.5 * Con + 0.5 * Str) / 2 > Healing)
                    {
                        _str -= _str * 0.1;
                        _dex -= _dex * 0.1;
                        _int -= _int * 0.1;
                        _con -= _con * 0.1;
                        _mana -= _mana * 0.1;
                        _healing -= _healing * 0.1;
                        _damag -= _damag * 0.1;
                        _def -= _def * 0.1;
                        _critChanse -= _critChanse * 0.1;
                        _critdamag -= _critdamag * 0.1;

                    }
                }
            }
            public double Mana
            {
                get => _mana;
                set
                {


                    _mana = Int * 2;
                }
            }
            public void FallHel()
            {
                if (147.5 / 2 > Healing)
                {
                    _str -= _str * 0.1;
                    _dex -= _dex * 0.1;
                    _int -= _int * 0.1;
                    _con -= _con * 0.1;
                    _mana -= _mana * 0.1;
                    _healing -= _healing * 0.1;
                    _damag -= _damag * 0.1;
                    _def -= _def * 0.1;
                    _critChanse -= _critChanse * 0.1;
                    _critdamag -= _critdamag * 0.1;

                }
            }
            public void FallMan()
            {
                if (Mana < 70)
                {
                    Healing = Healing - (_healing * 0.2);
                    Console.WriteLine();
                }
            }

            public void AttackM()
            {

                Console.WriteLine($"Юнит Mage  нанёс урон  по маникену {DamagM}");
            }
            public void AttackP()
            {

                Console.WriteLine($"Юнит Mage  нанёс урон  по маникену {DamagP}");
            }
            public void ShowInfo()
            {
                Console.WriteLine($" Str - {Str} Dex - {Dex} Con - {Con} Int - {Int} DamageM - {DamagM} DamageP - {DamagP} Health - {Healing} Mana - {Mana} DefM - {DefenseM} DefP - {DefenseP} Lvl - {Lvl} CritChanceM - {CritCgantM} CritChanceP - {CritCgantP} CritdamagM - {CritdamagM} CritdamagP - {CritdamagP}");

            }
        }

    }

