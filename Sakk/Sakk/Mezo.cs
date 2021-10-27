﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
    public class Mezo
    {
        public int X;
        public int Y;

        public Babu babu;
        public Mezo(int x, int y) 
        {
            X = x;
            Y = y;
        }

        public void Kirajzol()
        {
            if (babu != null)
            {
                if (babu.Szin == SzinEnum.feher)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }


                switch (babu.BabuTipus)
                {
                    case BabuTipusEnum.bastya:
                        {
                            Console.Write(" B "); break;
                        }
                    case BabuTipusEnum.futo:
                        {
                            Console.Write(" F "); break;
                        }
                    case BabuTipusEnum.gyalog:
                        {
                            Console.Write(" G "); break;
                        }
                    case BabuTipusEnum.vezer:
                        {
                            Console.Write(" V "); break;
                        }
                    case BabuTipusEnum.kiralyno:
                        {
                            Console.Write(" K "); break;
                        }
                    case BabuTipusEnum.lo:
                        {
                            Console.Write(" L "); break;
                        }
                    default:
                        {
                            Console.Write("   "); break;
                        }
                }
            }
            else
            {
                Console.Write("   ");
            }
        }
    }
}
