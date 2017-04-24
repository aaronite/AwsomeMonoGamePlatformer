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
    class Enemy
    {
        const int speed = 5;

        Sprite sprite = new Sprite();
        KeyboardState state;
        int enemyNum;

        public Enemy(int aEnemyNum, Color aColor, Vector2 aPos)
        {
            enemyNum = aEnemyNum;
            sprite.color = aColor;
            sprite.position = aPos;
        }
        public void Load(ContentManager content)
        {
            sprite.Load(content, "hero");
        }

        public void Update(float deltaTime)
        {
            state = Keyboard.GetState();

            if (enemyNum == 1)
            {
                if (state.IsKeyDown(Keys.D))
                    sprite.position.X += speed;

                if (state.IsKeyDown(Keys.A))
                    sprite.position.X -= speed;

                if (state.IsKeyDown(Keys.W))
                    sprite.position.Y -= speed;

                if (state.IsKeyDown(Keys.S))
                    sprite.position.Y += speed;
            }

            if (enemyNum == 2)
            {
                if (state.IsKeyDown(Keys.Right))
                    sprite.position.X += speed;

                if (state.IsKeyDown(Keys.Left))
                    sprite.position.X -= speed;

                if (state.IsKeyDown(Keys.Up))
                    sprite.position.Y -= speed;

                if (state.IsKeyDown(Keys.Down))
                    sprite.position.Y += speed;
            }

            sprite.Update(deltaTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            sprite.Draw(spriteBatch);
        }
    }
}

