using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceInvaders
{
    public class SpaceInvaders : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public static bool ShouldTurnAround;
        public static KeyboardState previousKeyboardState;


        // static GameSettings Settings;

        public SpaceInvaders()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = GameSettings.ScreenWidth;
            _graphics.PreferredBackBufferHeight = GameSettings.ScreenHeight;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            GameSettings.SpriteSheetTexture = Content.Load<Texture2D>("Textures/SpaceAnimation");
            GameSettings.ArialFont = Content.Load<SpriteFont>(@"Fonts\Arial20");


            GameSettings.PlayScreen.LoadContent();
            GameSettings.StartScreen.LoadContent();
            GameSettings.GameOverScreen.LoadContent();

            GameSettings.ActiveScreen = GameSettings.StartScreen;

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            GameSettings.ActiveScreen.Update(gameTime);
            previousKeyboardState = Keyboard.GetState();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            GameSettings.ActiveScreen.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}