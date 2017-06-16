namespace Component
{
    using World.GameObject;

    public class HealthComponent : Component
    {
        public override void update(GameObject originGameObject, GameObject gameObject)
        {
            // int hitPoints = originGameObject.GameObjectItemsContainer.GetCurrentWeapon().GetDamage();
            int hitPoints = 50;

            gameObject.Health -= hitPoints;

            if (gameObject.Health < 0) {
                gameObject.Destroyed = true;

                GenerateExplosion(gameObject);
            }
                

            // if < 20 -> damaged?
            // if < 10 -> scared? ruuuun bitch, ruuuuuuuun!
        }

        private void GenerateExplosion(GameObject gameObject)
        {
            GameObject explosion = gameObject.SceneManager.GameObjectManager.Get(9);
            explosion.position = gameObject.position;
            explosion.position.X -= 100; // explosion.getStartAnimationBox() 
            explosion.position.Y += 10;
            explosion.depth = 0.9f;
            gameObject.SceneManager.GameObjectManager.List.Add(explosion);
        }
    }
}
