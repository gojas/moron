using Microsoft.Xna.Framework.Input;
using System;

namespace Component.Input
{
    public class MoronInputComponent : InputComponent
    {

        public override void update(IGameObject gameObject)
        {

            KeyboardState state = Keyboard.GetState();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            Console.WriteLine("Moron says hello");
        }
    }
}
