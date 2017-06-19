using Microsoft.Xna.Framework;

using Content;

namespace Core.Service
{
    using Game1;
    using ParticleEngine2D;

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
            AddService<FrameCounter>(new FrameCounter());
            AddService(new IsometricCalculator(game.GraphicsDevice));
            AddService(new ParticleFactory(game.Content));
        }
    }
}