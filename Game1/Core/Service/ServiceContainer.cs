using Microsoft.Xna.Framework;

using Content;
using GameObject.Factory;

namespace Core.Service
{
    using Game1;

    public static class ServiceContainer
    {
        private static GameServiceContainer container;
        public static GameServiceContainer Instance
        {
            get
            {
                if (container == null)
                {
                    container = new GameServiceContainer();
                }
                return container;
            }
        }

        public static T GetService<T>()
        {
            return (T)Instance.GetService(typeof(T));
        }

        public static void AddService<T>(T service)
        {
            Instance.AddService(typeof(T), service);
        }

        public static void RemoveService<T>()
        {
            Instance.RemoveService(typeof(T));
        }

        public static void registerServices(Game1 game)
        {
            AddService<ContentManager>(new ContentManager(game));
            AddService<GameObjectFactory>(new GameObjectFactory(game));
        }
    }
}