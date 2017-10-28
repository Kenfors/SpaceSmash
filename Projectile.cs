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
    class Projectile
    {
        Texture2D texture;
        Vector2 position;
        Vector2 direction;
        int speed;

        public Projectile(Texture2D inTex, int inSpeed, Vector2 inPos, Vector2 inDir) {
            speed = inSpeed;
            texture = inTex;
            position = inPos;
            direction = inDir;
        }

        public void Update() {

            position.Y -= speed * direction.Y;
            position.X += speed * direction.X;

        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(texture, position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);

            // TODO: Add your drawing code here

        }

        private void onOverlap() {



        }

    }
}
