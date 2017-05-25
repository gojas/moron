namespace Core.Service
{
	using World.GameObject;
	using System;

	public static class CollisionDetection
	{
		public static bool rangeIntersect(float min0, float max0, float min1, float max1)
		{
			return Math.Max(min0, max0) >= Math.Min(min1, max1) &&
					Math.Min(min0, max0) <= Math.Max(min1, max1);
		}

        // FIX TO VECTORS, NOT GAME OBJECTS!!!!
        public static bool areRectanglesColliding(GameObject gameObject1, GameObject gameObject2) { // fix to position1x, position1y, widht, height, don't use game objects
            float gameObject1Width = 100;
            float gameObject2Width = 100;

            float gameObject1Height = 100;
            float gameObject2Height = 100;

            return rangeIntersect(gameObject1.position.X, gameObject1.position.X + gameObject1Width, gameObject2.position.X, gameObject2.position.X + gameObject2Width) &&
                    rangeIntersect(gameObject1.position.Y, gameObject1.position.Y + gameObject1Height, gameObject2.position.Y, gameObject2.position.Y + gameObject2Height);
        }


        public static bool areObjectsColliding(GameObject gameObject1, GameObject gameObject2)
		{
            // basically there will be something like 
            // if gameObject1.isRectangle && gameObject2.isRectangle check areRectanglesColliding
            // if gameObject1.isSphere && gameObject2.isRectangle check isRectangleCollidingWithSphere
            // if gameObject.1.isSphere && gameObject2.isSphere check areSpheresColliding

            // there will be also isPoint sooooo, yeah... much of stuff the stuff will be here...
            // make adapter like gameObject -> gameObjectCollidingAdapter -> CollisionDetection, don't just pass two gameObjects, make it more modular
            return areRectanglesColliding(gameObject1, gameObject2);
		}
    }
}