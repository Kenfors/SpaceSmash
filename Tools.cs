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


struct EntityData {



        public Vector2 Min;
        public Vector2 Max;
        public Vector2 Pos;
        public Vector2 Extent;

        public EntityData(Vector2 location, Vector2 size)
        {

            Pos = location;
            Extent = size;
            Min.X = location.X - size.X;
            Min.Y = location.Y - size.Y;
            Max.X = location.X + size.X;
            Max.Y = location.Y + size.Y;

        }

        public EntityData(Vector2 inMin, Vector2 inMax, int square)
        {
            this.Min = inMin;
            this.Max = inMax;
            this.Pos = inMin;
            Extent.X = (Int16)((inMax.X - inMin.X) / 2);
            Extent.Y = (Int16)((inMax.Y - inMin.Y) / 2);
            Pos.X += Extent.X;
            Pos.Y += Extent.Y;

        }


    }


    struct AttackData {

        public int attackRate;
        public Texture2D attackTexture;

        public int projectileSpeed;
        


    }



    class Tools
    {

       


        public static bool CheckCollision() {


            return false;

        }









    }
}
