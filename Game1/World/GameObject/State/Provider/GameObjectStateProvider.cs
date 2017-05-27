namespace World.GameObject.State.Provider
{
    public static class GameObjectStateProvider
    {

        public static string GetStateString(GameObject gameObject)
        {
            string name = gameObject.Name;

            if (null != gameObject.State.currentMovementState)
                name += gameObject.State.currentMovementState;

            if (null != gameObject.State.currentWeaponName)
                name += gameObject.State.currentWeaponName;

            return name;
        }
    }
}
