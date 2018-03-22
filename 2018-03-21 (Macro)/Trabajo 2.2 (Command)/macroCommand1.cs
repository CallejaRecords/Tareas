using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2._2__Command_
{
    class macroCommand1: Command
    {
        List<Command> macro = new List<Command>();
        public void addMacro(Command accion)
        {
            macro.Add(accion);
        }
        public void removeMacro(Command accion)
        {
            macro.Remove(accion);
        }
        public void resetMacro()
        {
            macro.Clear();
        }
        public void execute()
        {
            foreach (Command c in macro)
            {
                c.execute();
            }
        }

        public void undo()
        {
            foreach (Command c in macro)
            {
                c.undo();
            }
        }
    }
}
