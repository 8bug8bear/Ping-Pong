using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    class Sprite
    {
        public Bitmap CurrenSprote;
        public bool Show;
        public int x, y,width, height;
        public Sprite (string filename, int x,int y)
        {
            CurrenSprote = new Bitmap(filename);
            this.x = x;
            this.y = y;
            this.width = CurrenSprote.Width;
            this.height = CurrenSprote.Height;
            Show = true;
        }
        public Sprite(string filename, int x, int y, int w, int h)
        {
            CurrenSprote = new Bitmap(filename);
            this.x = x;
            this.y = y;
            this.width = w;
            this.height = h;
            Show = true;
        }

        public bool SpriteCollision(Sprite s)
        {
            Sprite temp = this;
            Rectangle A = new Rectangle(s.x, s.y, s.width, s.height);
            Rectangle B = new Rectangle(temp.x, temp.y, temp.width, temp.height);

            if (A.IntersectsWith(B))
                return true;
            else return false;

        }
    }
}
