using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Component.Input;
using Component;

namespace Object
{
    public class GameObject : IGameObject
    {
        Vector2 position;
        ComponentContainer componentContainer;

        public GameObject(ComponentContainer aComponentContainer)
        {
            componentContainer = aComponentContainer;
        }

        public void update()
        {
            componentContainer.getAll().ForEach((component) =>
            {
                component.update(this);
            });
        }

        public ComponentContainer getComponentContainer()
        {
            return componentContainer;
        }
    }
}
