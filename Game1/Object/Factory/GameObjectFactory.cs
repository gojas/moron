using Component;
using Component.Input;
using Component.Physics;
using Component.Graphic;

namespace Object.Factory
{
    using Game1;
    using System;
    using System.Linq;

    public class GameObjectFactory
    {
        ComponentContainer componentContainer;

        private const string COMPONENT_NAME_INPUT = "Input";
        private const string COMPONENT_NAME_PHYSICS = "Physics";
        private const string COMPONENT_NAME_GRAPHIC = "Graphic";

        Game1 game;

        public GameObjectFactory(Game1 aGame)
        {
            game = aGame;
        }

        public GameObject get(ComponentContainer componentContainer)
        {
            return new GameObject(componentContainer);
            // Moron -> UpdateAware, DrawAware, PhysicsAware

            // Brick -> DrawAware

            /**
            GameObject gameObject = new GameObject(
                getInputComponent(name),
                getPhysicsComponent(name),
                getGraphicComponent(name)
            );

    **/
            // if implements Updateable, add setOnUpdate, getOnUpdate etc... 
            // cars can update, bricks don't! except some draw particles, but that is Drawable

        }

        private string getComponentNamespaceName(string type)
        {
            return "Component." + type;
        }

        private string getComponentName(string type)
        {
            return type + "Component";
        }

        private string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("String not defined!");
            return input.First().ToString().ToUpper() + String.Join("", input.Skip(1));
        }

        private InputComponent getInputComponent(string name)
        {
            string namespaceName = getComponentNamespaceName(COMPONENT_NAME_INPUT);
            string componentName = getComponentName(COMPONENT_NAME_INPUT);

            if (Type.GetType(namespaceName + "." + this.FirstCharToUpper(name) + componentName) != null)
            {
                componentName = this.FirstCharToUpper(name) + componentName;
            }

            return Activator.CreateInstance(Type.GetType(namespaceName + "." + componentName)) as InputComponent;
        }

        private PhysicsComponent getPhysicsComponent(string name)
        {
            string namespaceName = getComponentNamespaceName(COMPONENT_NAME_PHYSICS);
            string componentName = getComponentName(COMPONENT_NAME_PHYSICS);

            if (Type.GetType(namespaceName + "." + this.FirstCharToUpper(name) + componentName) != null)
            {
                componentName = this.FirstCharToUpper(name) + componentName;
            }

            return Activator.CreateInstance(Type.GetType(namespaceName + "." + componentName)) as PhysicsComponent;
        }

        private GraphicComponent getGraphicComponent(string name)
        {
            string namespaceName = getComponentNamespaceName(COMPONENT_NAME_GRAPHIC);
            string componentName = getComponentName(COMPONENT_NAME_GRAPHIC);

            if (Type.GetType(namespaceName + "." + this.FirstCharToUpper(name) + componentName) != null)
            {
                componentName = this.FirstCharToUpper(name) + componentName;
            }

            return Activator.CreateInstance(Type.GetType(namespaceName + "." + componentName)) as GraphicComponent;
        }
    }
}