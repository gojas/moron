﻿using Microsoft.Xna.Framework;

namespace Content
{
    using Game1;
    using QuadTree;
    using Texture;
    using World.Scene;
    using World.GameObject;
    using System.Collections.Generic;

    public class ContentManager : IContentManager
    {
        Game1 game;

        SceneManager sceneManager;
        
        QuadTree quadTree;
        SpriteRender spriteRender;
        List<GameObject> gameObjectList;

        public ContentManager(Game1 game1)
        {
            game = game1;
        }

        public void loadContent()
        {
            sceneManager = new SceneManager(game.Content);

            sceneManager.FirstGet(1).ThenLoadScene().InitScene();

            quadTree = new QuadTree(new Rectangle(0, 0, game.GraphicsDevice.Viewport.Bounds.Width, game.GraphicsDevice.Viewport.Bounds.Height));

            spriteRender = new SpriteRender(game.getSpriteBatch());
        }

        public void updateInput(GameTime gameTime)
        {
            game.getCamera().Update(gameTime);

            quadTree.clear();
            gameObjectList = sceneManager.GetSceneObjectsContainer(1, 2).GetAll();

            // 1, 2 means get only specific objects, based on position.X and position.Y
            gameObjectList.ForEach((gameObject) => {
                // prepare data for physics component
                if (null != gameObject.getComponentContainer().getPhysicsComponent())
                    quadTree.insert(gameObject);
            });

            gameObjectList.ForEach((gameObject) => {
                /** handle user input here **/
                if (null != gameObject.getComponentContainer().getInputComponent())
                    gameObject.getComponentContainer().getInputComponent().update(gameObject, game);

                /** checking the state of a game, did player hit the wall? **/
                if (null != gameObject.getComponentContainer().getPhysicsComponent())
                    gameObject.getComponentContainer().getPhysicsComponent().update(gameObject, quadTree);
            });
        }

        public void updateGraphic(GameTime gameTime)
        {
            gameObjectList.ForEach((gameObject) => {
                if (null != gameObject.getComponentContainer().getGraphicComponent())
                    gameObject.getComponentContainer().getGraphicComponent().update(gameObject, spriteRender, gameTime);
            });

        }
    }
}
