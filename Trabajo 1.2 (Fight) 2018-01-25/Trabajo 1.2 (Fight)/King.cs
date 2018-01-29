using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._2__Fight_
{
    class King: Character
    {
        public King()
        {
            WeaponBehavior courage = new Sword();
            setWeapon(courage);
        }
        public override void fight()
        {
            Console.WriteLine("As the king of this land, I deem your actions punishable by death with my ");
            base.fight();
        }
    }
}
