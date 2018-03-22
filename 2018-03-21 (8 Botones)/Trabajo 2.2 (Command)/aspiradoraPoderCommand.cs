﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class aspiradoraPoderCommand: Command
    {
        Aspiradora aspiradora;
        public aspiradoraPoderCommand(Aspiradora a)
        {
            this.aspiradora = a;
        }
        public void execute()
        {
            aspiradora.poderAspiradora(true);
        }

        public void undo()
        {
            aspiradora.poderAspiradora(false);
        }
    }
}
