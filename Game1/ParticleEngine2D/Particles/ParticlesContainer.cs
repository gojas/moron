using Microsoft.Xna.Framework;
using System;

namespace ParticleEngine2D
{
    public class ParticlesContainer
    {
        Random random;

        public static object GetById(int id)
        {
            Random random = new Random();

            var list = new[]
            {
                new {
                    Name = "Snow",
                    Texture = "ember",
                    Velocity = new Vector2(
                        GetRandomFloat(0.2, 1),
                        GetRandomFloat(0.8, 1.6)
                    ),
                    Angle = 0,
                    AngularVelocity = 0.1f * (float)(random.NextDouble() * 2 - 1),
                    Color = new Color(
                        (float)random.NextDouble(),
                        (float)random.NextDouble(),
                        (float)random.NextDouble()),
                    Size = (float)random.NextDouble(),
                    TTL = random.Next(1, 500)
                }
            };

            return list[id];
        }
        
        // GU: create math helper
        private static float GetRandomFloat(double minimum, double maximum)
        {
            Random random = new Random();

            double number = random.NextDouble() * (maximum - minimum) + minimum;

            return (float)number;
        }
    }
}
