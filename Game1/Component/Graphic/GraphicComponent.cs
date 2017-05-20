namespace Component.Graphic
{
    public class GraphicComponent : IComponent
    {
        public void update(IGameObject gameObject)
        {

            // based on gameObject.position DRAW 

            // spriteBatch.Draw(gameObject.texture, gameObject.position, gameObject.position2, Color.White);
        }
    }
}
