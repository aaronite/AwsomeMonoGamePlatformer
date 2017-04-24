using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace AwsomePlatFormer
{
    class Player
    {
 
        const int speed = 5;

        Sprite sprite = new Sprite();
        KeyboardState state;
        int playerNum;
        String skin;

        public Player(int aPlayerNum, Color aColor, Vector2 aPos, String aSkin)
        {
            playerNum = aPlayerNum;
            sprite.color = aColor;
            sprite.position = aPos;
            skin = aSkin;
        }

        public void Load(ContentManager content)
        {
            sprite.Load(content, skin);
        }

        public void Update(float deltaTime)
        {
            state = Keyboard.GetState();

            if (playerNum == 1)
            {
                if (state.IsKeyDown(Keys.D) || state.IsKeyDown(Keys.Right))
                {
                    sprite.position.X += speed;
                }

                if (state.IsKeyDown(Keys.A) || state.IsKeyDown(Keys.Left))
                {
                    sprite.position.X -= speed;
                }

                if (state.IsKeyDown(Keys.W) || state.IsKeyDown(Keys.Up))
                {
                    sprite.position.Y -= speed;
                }

                if (state.IsKeyDown(Keys.S) || state.IsKeyDown(Keys.Down))
                {
                    sprite.position.Y += speed;
                }
            }

            sprite.Update(deltaTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }
    }
}
