namespace Component
{
    using World.GameObject;
    using QuadTree;
    using World.Scene;

    public class ExplosionSpawnScriptComponent : ScriptComponent
    {
        public override void update(GameObject gameObject, QuadTree quadTree, SceneManager sceneManager)
        {
            GameObject explosion = sceneManager.GameObjectManager.Get(9); // explosion

            explosion.position.X = gameObject.position.X;
            explosion.position.Y = gameObject.position.Y;
            sceneManager.GameObjectManager.List.Add(explosion);
        }
    }
}
