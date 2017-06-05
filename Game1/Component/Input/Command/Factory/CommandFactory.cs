using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component.Input.Command.Factory
{
    public class CommandFactory
    {
        private static readonly string[] InvalidCommands = { "AD", "DA", "WS", "SW" };

        public static Command Get(KeyboardState state)
        {
            string pressedKeysString = "";

            foreach (Keys pressedKey in state.GetPressedKeys())
            {
                pressedKeysString += pressedKey.ToString();
            }

            if (null == Type.GetType("Component.Input.Command.Command" + pressedKeysString))
                pressedKeysString = "";
                // (GU): Log here

            // CommandAWLeftMouse
            return Activator.CreateInstance(Type.GetType("Component.Input.Command.Command" + pressedKeysString)) as Command;
        }
    }
}
