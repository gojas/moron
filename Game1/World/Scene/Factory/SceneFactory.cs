namespace World.Scene.Factory
{
    using World.Scene.Scenes;

    public static class SceneFactory
    {
        public static Scene Get(int id)
        {
            return new Scene_1();
        }
    }
}
