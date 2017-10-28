using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceSmash
{
    class Player : Entity
    {

        float attackCD;

        public Player(Vector2 location, Vector2 size) {

            unitdata = new EntityData(location, size);
            speed = 5;
            attackCD = 0;
        }


        public override void Update(GameTime gameTime) {
            base.Update(gameTime);

            if (Keyboard.GetState().IsKeyDown(Keys.W)) {
                unitdata.Pos.Y -= speed;

            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                unitdata.Pos.Y += speed;

            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                unitdata.Pos.X -= speed;

            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                unitdata.Pos.X += speed;

            }


            if (Keyboard.GetState().IsKeyDown(Keys.Up) && attackCD <= 0)
            {

                projectiles.Add(new Projectile(attack.attackTexture, attack.projectileSpeed, unitdata.Pos, new Vector2(0, 1f)));
                attackCD = attack.attackRate * 50;

            }
            attackCD -= gameTime.ElapsedGameTime.Milliseconds;

            System.Diagnostics.Debug.WriteLine("time: " + gameTime.ElapsedGameTime.Milliseconds);

        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);

            spriteBatch.Draw(texture, unitdata.Pos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);

            // TODO: Add your drawing code here

        }
    }
}
