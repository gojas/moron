using Microsoft.Xna.Framework.Input;
using Component.Input.Command.Factory;
using Component.Input.Command;

namespace Component
{
    using World.GameObject;
    using Comora;
    using Core.Service;
    using World.GameObject.State.States;
    using Microsoft.Xna.Framework;
    using System;

    public class MoronInputComponent : InputComponent
    {

        public override void update(GameObject gameObject, Camera camera)
        {

            float moronPositionX = gameObject.position.X;
            float moronPositionY = gameObject.position.Y;


            KeyboardState state = Keyboard.GetState();
            MouseState mouseState = Mouse.GetState();

            float mousePositionX = mouseState.Position.X;
            float mousePositionY = mouseState.Position.Y;

            Vector2 mousePosition = new Vector2(mousePositionX, mousePositionY);



            if (mouseState.LeftButton == ButtonState.Pressed) {
                IsometricCalculator isometricCalculator = ServiceContainer.GetService<IsometricCalculator>();
                Vector2 gameObjectTileCordinates = isometricCalculator.GetTileCoordinates(gameObject.position);


                System.Diagnostics.Debug.Write(gameObject.position + "\n");

                // gameObject.position = mousePosition; // la la :D

                System.Diagnostics.Debug.Write(mousePosition + "\n");
            }

            if (mouseState.RightButton == ButtonState.Pressed) {
                GameObject rangeWeaponGameObject = gameObject.SceneManager.GameObjectManager.Get(4);

                rangeWeaponGameObject.ComponentContainer.GetScriptComponent().update(gameObject, gameObject.QuadTree, gameObject.SceneManager);

                // gameObject.FireRange();
            }
                

            Command command = CommandFactory.Get(state);



            


            command.Update(gameObject);

            camera.Position = gameObject.position;


            



        }
    }
}
