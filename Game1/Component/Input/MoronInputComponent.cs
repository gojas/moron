﻿using Microsoft.Xna.Framework.Input;
using Component.Input.Command.Factory;
using Component.Input.Command;

namespace Component
{
    using World.GameObject;
    using World.GameObject.State;
    using World.GameObject.Item;
    using Game1;

    public class MoronInputComponent : InputComponent
    {

        public override void update(GameObject gameObject, Game1 game)
        {
            KeyboardState state = Keyboard.GetState();

            gameObject.State.currentMovementState = MovementState.STANDING;

            gameObject.State.SetCurrentWeaponName("Pistol");

            GameObjectItem weapon = gameObject.State.GetCurrentWeapon();


            string pressedKeysString = "";

            foreach (Keys pressedKey in state.GetPressedKeys()) {
                pressedKeysString += pressedKey.ToString();
            }

            Command command = CommandFactory.Get(pressedKeysString);

            command.Update(gameObject);

            System.Diagnostics.Debug.Write(gameObject.position.X);

            game.getCamera().Position = gameObject.position;
        }
    }
}
