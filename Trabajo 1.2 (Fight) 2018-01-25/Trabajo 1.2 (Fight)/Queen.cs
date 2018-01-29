using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._2__Fight_
{
    class Queen: Character
    {
        public Queen()
        {
            WeaponBehavior tactics = new BowAndArrow();
            setWeapon(tactics);
        }
        public override void fight()
        {
            Console.WriteLine("I stand here to protect what is innocent, thou shall perish with my   ");
            base.fight();
        }
    }
}
