using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.Input.Command.Factory
{
    public class CommandFactory
    {
        public static Command Get(string name)
        {
            if (name == "WD")
                name = "DW";
            if (name == "DS")
                name = "SD";
            if (name == "SA")
                name = "AS";
            if (name == "AW")
                name = "WA";

            return Activator.CreateInstance(Type.GetType("Component.Input.Command.Command" + name)) as Command;
        }
    }
}
