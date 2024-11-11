using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

namespace EasyTurnAtEdge
{
    internal class MyWorld : World
    {
        public MyWorld() : base(800, 600)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "sand2";

            Add(new Spider(), "spider", 400, 300);
        }  
    }
}
