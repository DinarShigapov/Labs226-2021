﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021
{
    
    public class Warrior : Charter
    {
        public int Str
        {
            get => _str;
            set
            {
                if (value > 250 & value < 30)
                {
                    _str = value;
                }
                else
                if(value < 30)
                {
                    _str = 30;

                }
                else
                {
                    _str = 250;
                }
            }
        }
        public int Dex
        {
            get => _dex;
            set
            {
                if (value > 80 & value < 15)
                {
                    _dex = value;
                }
                else
                if (value < 15)
                {
                    _dex = 15;

                }
                else
                {
                    _dex = 80;
                }
            }
        }
        public int Con
        {
            get => _con;
            set
            {
                if (value > 100 & value < 25)
                {
                    _con = value;
                }
                else
                if (value < 25)
                {
                    _con = 25;

                }
                else
                {
                    _con = 100;
                }
            }
        }
        public int Int
        {
            get => _int;
            set
            {
                if (value > 50  & value < 10)
                {
                    _int = value;
                }
                else
                if (value < 10)
                {
                    _int = 10;

                }
                else
                {
                    _int = 50;
                }
            }
        }
        public double PhysicDamage
        {
            get => _physicdamage;
            set
            {
                value = Str * 3 + Dex * 0.5;
                _physicdamage = value;
            }

        }
        public double MagicDamage
        {
            get => _magicdamage;
            set
            {
                value = Int * 4;
                _magicdamage = value;
            }

        }
        public double PhysicDefence
        {
            get => _physicdefence;
            set
            {
                value = Dex * 3 + Con * 0.5;
                _physicdefence = value;
            }
        }
        public double MagicDefence
        {
            get => _magicdefence;
            set
            {
                value = Int * 2;
                _magicdefence = value;
            }
        }

        public double Health { get => _health; set => _health = 2 * Con + 0.5 * Str; }
        public int Mana { get => _mana; set => _mana = Int * 3; }

        public  void Attack()
        {
            Console.WriteLine($"Юнит  нанёс {PhysicDamage} уроа");
        }
        public void ShowInfo() 
        {
           Console.WriteLine($"Нынешние параметры Силы: {Str}, Ловкости: {Dex}, Телосложения: {Con}, Интелекта: {Int}, Физ. атаки: {PhysicDamage}, Маг. атаки: {MagicDamage}, Физ. защиты: {PhysicDefence}, Маг.защиты: {MagicDefence}, Здоровья: {Health}, Манны: {Mana}");
        }
    }
    
}
