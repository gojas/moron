﻿using Microsoft.Xna.Framework.Input;
using Component.Input.Command.Factory;
using Component.Input.Command;

namespace Component
{
    using World.GameObject;
    using Comora;
    using Core.Service;
    using World.GameObject.State.States;
    using Microsoft.Xna.Framework;

    public class MoronInputComponent : InputComponent
    {

        public override void update(GameObject gameObject, Camera camera)
        {
            KeyboardState state = Keyboard.GetState();
            MouseState mouseState = Mouse.GetState();

            // gameObject.State.currentMovementState = MovementState.STANDING;



            if (mouseState.LeftButton == ButtonState.Pressed) {
                IsometricCalculator isometricCalculator = ServiceContainer.GetService<IsometricCalculator>();
                Vector2 gameObjectTileCordinates = isometricCalculator.GetTileCoordinates(gameObject.position);


                System.Diagnostics.Debug.Write(gameObject.position + "\n");


                Vector2 mousePosition = new Vector2(mouseState.Position.X, mouseState.Position.Y);

                gameObject.position = mousePosition;

                System.Diagnostics.Debug.Write(mousePosition + "\n");
            }
                
            /**
            if (mouseState.RightButton == ButtonState.Pressed)
                pressedKeysString += "RightMouse";

            **/

            Command command = CommandFactory.Get(state);



            


            command.Update(gameObject);

            camera.Position = gameObject.position;


            



        }
    }
}
