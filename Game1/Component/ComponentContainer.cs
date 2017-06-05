using System.Collections.Generic;

namespace Component
{
    public class ComponentContainer : IComponentContainerAware
    {
        private List<Component> components = new List<Component>();

        public ComponentContainer()
        {
            
        }

        public void Add(Component component)
        {
            components.Add(component);
        }

        public void Remove(Component component)
        {
            components.Remove(component);
        }

        public void Clear()
        {
            components.Clear();
        }

        public List<Component> GetAll()
        {
            return components;
        }

        public Component GetInputComponent()
        {
            return components.Find((Component component) =>
            {
                return component is InputComponent;
            });
        }

        public Component GetGraphicComponent()
        {
            return components.Find((Component component) =>
            {
                return component is GraphicComponent;
            });
        }

        public Component GetPhysicsComponent()
        {
            return components.Find((Component component) =>
            {
                return component is PhysicsComponent;
            });
        }

        public Component GetScriptComponent()
        {
            return components.Find((Component component) =>
            {
                return component is ScriptComponent;
            });
        }

        public Component GetHealthComponent()
        {
            return components.Find((Component component) =>
            {
                return component is HealthComponent;
            });
        }
    }
}
