using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1._2__Fight_
{
    class Character
    {
        public WeaponBehavior style;

        public virtual void fight() { style.useWeapon(); }

        public void setWeapon(WeaponBehavior w)
        {
            this.style = w;
        }
    }
}
