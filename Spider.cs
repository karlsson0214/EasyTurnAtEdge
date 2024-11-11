using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;

namespace EasyTurnAtEdge
{
    internal class Spider : Actor
    {
        private float speed = 500;
        public Spider()
        {

        }

        public override void Update(GameTime gameTime)
        {
            Move((float)gameTime.ElapsedGameTime.TotalSeconds * speed);
            if (IsAtEdge())
            {
                Turn(57);
            }
        }


    }
}
