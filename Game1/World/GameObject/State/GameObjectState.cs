namespace World.GameObject.State
{
    using World.GameObject.Item;

    public class MovementState
    {
        public const string STANDING = "Standing";

        public const string WALKING_UP = "WalkingUp";
        public const string WALKING_UP_LEFT = "WalkingUpLeft";
        public const string WALKING_UP_RIGHT = "WalkingUpRight";

        public const string WALKING_DOWN = "WalkingDown";
        public const string WALKING_DOWN_LEFT = "WalkingDownLeft";
        public const string WALKING_DOWN_RIGHT = "WalkingDownRight";

        public const string WALKING_LEFT = "WalkingLeft";
        public const string WALKING_RIGHT = "WalkingRight";
    }

    public class WeaponState
    {
        public const string PISTOL = "Pistol";
    }

    public class GameObjectState
    {
        GameObject gameObject;
        
        public string currentMovementState;
        public string currentWeaponName;

        public GameObjectState(GameObject gameObject)
        {
            this.gameObject = gameObject;
            this.currentMovementState = MovementState.STANDING;
        }

        public void SetCurrentWeaponName(string name)
        {
            this.currentWeaponName = name;
        }

        public GameObjectItem GetCurrentWeapon()
        {
            return gameObject.GetWeaponItem(this.currentWeaponName);
        }

        public bool isMoving()
        {
            return currentMovementState != MovementState.STANDING;
        }
    }
}
