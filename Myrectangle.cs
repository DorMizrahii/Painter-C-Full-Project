using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp6
{
    [Serializable]
    class Myrectangle : Shape_Blocked_By_Rectangle
    {
        public Myrectangle(int color, int size_pen, Point start, Point end, int width, int length)
        {
            this.COLOR = color; this.Size_pen = size_pen;
            this.Start = start; this.End = end;
            this.width = width;
            this.length = length;
           // this.Color_inside.Push(color_inside);
            count++;
            this.id_ = count;
        }


        public override void Draw( Bitmap bm, Graphics g)
        {
            //  SolidBrush br;

            // if (color_inside.Count == 0)
            //    br = new SolidBrush(Color.Transparent);
            // else
            // br = new SolidBrush(Color.FromArgb(color_inside.Peek()));
            // g.FillRectangle(br, start.X, start.Y, width, length);
            //g.DrawRectangle(new Pen(Color.FromArgb(COLOR), size_pen), this.start.X, this.start.Y, Width, Length);
            //int minX = this.Start.X < this.End.X ? this.Start.X : this.End.X;
            //int minY = this.Start.Y < this.End.Y ? this.Start.Y : this.End.X;
            g.DrawRectangle(new Pen(Color.FromArgb(COLOR), size_pen), this.Start.X, this.Start.Y, this.Width, this.Length);
        }



        public override bool Is_Inside(int x, int y)
        {
            int mid_x, mid_y;
            mid_x = (start.X - end.X) / 2 + end.X;
            mid_y = (start.Y - end.Y) / 2 + end.Y;
            return (Math.Abs(mid_x - x) <= width / 2 && Math.Abs(mid_y - y) <= length / 2);


        }
    }
}
