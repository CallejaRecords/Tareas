using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._2__Fight_
{
    class Troll: Character
    {
        public Troll()
        {
            WeaponBehavior rage = new Axe();
            setWeapon(rage);
        }
        public override void fight()
        {
            Console.WriteLine("You think you are better than me? for that you deserve to be slaughter by my  ");
            base.fight();
        }
    }
}
