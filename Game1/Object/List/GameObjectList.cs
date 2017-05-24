namespace GameObject.List
{

    public static class GameObjectList
    {
        // pusi kurac
        public static object getById(int id)
        {
            var list = new[]
            {
                new {
                    velocity = 50,
                    textureAtlas = "cowboy",
                    components = new string[] { "MoronInputComponent", "MoronPhysicsComponent", "MoronGraphicComponent" }
                }
            };

            return list[id];
        }

    }
}
