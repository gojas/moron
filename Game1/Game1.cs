﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Content;
using Core.Service;
using Comora;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {

        GraphicsDeviceManager graphics;
        ContentManager ContentManager;
        FrameCounter frameCounter;

        SpriteBatch spriteBatch;

        private Camera camera;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);

            ServiceContainer.registerServices(this);

            ContentManager = ServiceContainer.GetService<ContentManager>();
            frameCounter = ServiceContainer.GetService<FrameCounter>();

            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            camera = new Camera(GraphicsDevice);

            IsMouseVisible = true;

            graphics.PreferredBackBufferWidth = GraphicsDevice.DisplayMode.Width;
            graphics.PreferredBackBufferHeight = GraphicsDevice.DisplayMode.Height;
            graphics.IsFullScreen = true;
            graphics.ApplyChanges();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            camera.LoadContent(GraphicsDevice);

            ContentManager.LoadContent(GraphicsDevice);


            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            /** player or AI input goes here **/
            ContentManager.Update(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            var deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            frameCounter.Update(deltaTime);

            graphics.GraphicsDevice.Clear(Color.White);
            
            spriteBatch.Begin(/** this.camera ,*/ SpriteSortMode.FrontToBack, BlendState.AlphaBlend);

            /** draw! **/
            ContentManager.Draw(gameTime);

            spriteBatch.End();


            base.Draw(gameTime);
        }

        public SpriteBatch getSpriteBatch()
        {
            return spriteBatch;
        }

        public Camera getCamera()
        {
            return camera;
        }
    }
}
