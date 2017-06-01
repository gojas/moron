namespace Component
{
    using World.GameObject;
    using QuadTree;
    using World.Scene;

    public class MoronSpawnScriptComponent : ScriptComponent
    {
        public override void update(GameObject gameObject, QuadTree quadTree, SceneManager sceneManager)
        {
            if (!gameObject.Disabled)
            {
                GameObject moron = sceneManager.GameObjectManager.Get(2);
                moron.position.X = gameObject.position.X + 100;
                moron.position.Y = gameObject.position.Y - 100;
                gameObject.depth = 0.1f;
                sceneManager.SceneObjectContainer.Add(moron);

                gameObject.Disabled = true;
            }
            
        }
    }
}
