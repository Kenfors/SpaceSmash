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
    class Entity
    {

        protected EntityData unitdata;
        protected Texture2D texture;
        protected Int16 speed;

        protected Rectangle collider;

        protected AttackData attack;
        protected List<Projectile> projectiles;


        public Entity() {
            projectiles = new List<Projectile>();

        }


        public void Init(Texture2D inTex, AttackData inAtk)
        {
            texture = inTex;
            attack = inAtk;

        }

        public virtual void Update(GameTime gameTime)
        {
            
            foreach (Projectile current in projectiles) {
                current.Update();


            }



        }


        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            foreach (Projectile current in projectiles)
            {
                current.Draw(gameTime, spriteBatch);


            }



        }

    }
}
