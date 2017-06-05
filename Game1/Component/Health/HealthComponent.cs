namespace Component
{
    using World.GameObject;

    public class HealthComponent : Component
    {
        public override void update(GameObject originGameObject, GameObject gameObject)
        {
            // int hitPoints = originGameObject.GameObjectItemsContainer.GetCurrentWeapon().GetDamage();
            int hitPoints = 1;

            gameObject.Health -= hitPoints;

            if (gameObject.Health < 0)
                gameObject.Destroyed = true;

            // if < 20 -> damaged?
            // if < 10 -> scared? ruuuun bitch, ruuuuuuuun!
        }
    }
}
