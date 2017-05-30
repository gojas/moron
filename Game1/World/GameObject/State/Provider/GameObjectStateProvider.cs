namespace World.GameObject.State.Provider
{
    public static class GameObjectStateProvider
    {

        public static string GetStateString(GameObject gameObject)
        {
            string name = gameObject.Name;

            if (null != gameObject.GameObjectStateContainer.GetPrevious())
                name += gameObject.GameObjectStateContainer.GetPrevious().GetStateAsAString();

            if (null != gameObject.State.currentWeaponName)
                name += gameObject.State.currentWeaponName;

            return name;
        }
    }
}
