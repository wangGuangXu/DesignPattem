using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式06
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeaponBehavior weapon = new KnifeBehavior();

            //皇后
            Character queen = new Queen();
            Console.WriteLine("皇后");
            queen.Fight();
            //更换武器
            queen.SetWeapon(new BowAndArrowBehavior());
            queen.Fight();


            //骑士
            queen = new Knight();
            Console.WriteLine("\r\n骑士");
            queen.Fight();
            
            //更换武器
            queen.SetWeapon(new AxeBehavior());
            queen.Fight();

            Console.ReadLine();

        }
    }
}
