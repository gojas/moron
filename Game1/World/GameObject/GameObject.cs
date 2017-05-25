using Microsoft.Xna.Framework;
using Component;
using Texture;

namespace World.GameObject
{
    public class State
    {
        public const string STATE_STANDING = "STATE_STANDING";
        public const string STATE_WALKING_UP = "STATE_WALKING_UP";
        public const string STATE_WALKING_DOWN = "STATE_WALKING_DOWN";
        public const string STATE_WALKING_LEFT = "STATE_WALKING_LEFT";
        public const string STATE_WALKING_RIGHT = "STATE_WALKING_RIGHT";
    }

    public class GameObject
    {
        public Vector2 position;

        public AnimationContainer animationContainer;
        public ComponentContainer componentContainer;
        public string state;

        // huh hah?!
        public float speed = 5;

        public GameObject(
            AnimationContainer animationContainer,
            ComponentContainer componentContainer
        )
        {
            this.animationContainer = animationContainer;
            this.componentContainer = componentContainer;
            this.state = State.STATE_STANDING;
        }

        public ComponentContainer getComponentContainer()
        {
            return componentContainer;
        }

        public string getState()
        {
            return state;
        }
    }
}