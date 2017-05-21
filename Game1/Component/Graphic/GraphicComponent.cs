namespace Component.Graphic
{
    public class GraphicComponent : AbstractComponent
    {
        public override void update(IGameObject gameObject)
        {

            // based on gameObject.position DRAW 

            // spriteBatch.Draw(gameObject.texture, gameObject.position, gameObject.position2, Color.White);

            System.Diagnostics.Debug.WriteLine("GRAPHIC HELLO");
        }
    }
}
