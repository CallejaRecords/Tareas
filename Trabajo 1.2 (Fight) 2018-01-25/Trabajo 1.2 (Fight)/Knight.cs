using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._2__Fight_
{
    class Knight: Character
    {
        public Knight()
        {
            WeaponBehavior honor = new Sword();
            setWeapon(honor);
        }
        public override void fight()
        {
            Console.WriteLine("By the commandment of my king, I shall slay you with my ");
            base.fight();
        }
    }
}
