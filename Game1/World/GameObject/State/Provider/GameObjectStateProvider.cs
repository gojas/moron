namespace World.GameObject.State.Provider
{
    public static class GameObjectStateProvider
    {

        public static string GetStateString(GameObject gameObject)
        {
            string name = gameObject.name;

            if (null != gameObject.state.currentMovementState)
                name += gameObject.state.currentMovementState;

            if (null != gameObject.state.currentWeaponName)
                name += gameObject.state.currentWeaponName;

            return name;
        }
    }
}
