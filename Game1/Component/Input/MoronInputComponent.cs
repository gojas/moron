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
        MouseState oldMouseState;

        public override void update(GameObject gameObject, Camera camera)
        {
            KeyboardState state = Keyboard.GetState();
            MouseState mouseState = Mouse.GetState();

            Vector2 mousePosition = mouseState.Position.ToVector2();

            if (mouseState.LeftButton == ButtonState.Pressed) {
                IsometricCalculator isometricCalculator = ServiceContainer.GetService<IsometricCalculator>();
                Vector2 gameObjectTileCordinates = isometricCalculator.GetTileCoordinates(gameObject.position);
                
            }

            if (mouseState.RightButton == ButtonState.Pressed && 
                oldMouseState.RightButton == ButtonState.Released
            ) {
                gameObject.GameObjectStateContainer.Change(new StateFiringRange());

                GameObject rangeWeaponGameObject = gameObject.SceneManager.GameObjectManager.Get(4);

                rangeWeaponGameObject.ComponentContainer.GetScriptComponent().update(gameObject, gameObject.QuadTree, gameObject.SceneManager);

                // gameObject.FireRange();
            }

            Command command = CommandFactory.Get(state);

            command.Update(gameObject);
            camera.Position = gameObject.position;
            oldMouseState = mouseState;
        }
    }
}
