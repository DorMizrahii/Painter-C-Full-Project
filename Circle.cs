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
    class Circle : Shape_Blocked_By_Rectangle
    {



        public Circle(int color, int size_pen, Point start, Point end, int width, int length)
        {
            this.color = color; this.size_pen = size_pen;
            this.start = start; this.end = end;
            this.width = width;
            this.Length = length;
          //  this.Color_inside.Push(color_inside);

            count++;
            this.id_ = count;
        }


   
        public override void Draw( Bitmap bm, Graphics g)
        {
           // SolidBrush br;
           Pen p = new Pen(Color.FromArgb(COLOR), size_pen);
          //  if (color_inside.Count == 0)
              //  br = new SolidBrush(Color.Transparent);
           // else
               // br = new SolidBrush(Color.FromArgb(color_inside.Peek()));
           //// g.FillEllipse(br, start.X, start.Y, width, length);

             g.DrawEllipse(p, this.Start.X, this.Start.Y, width, length);
          
        }

        public override bool Is_Inside(int x, int y)
        {

            int elipseCenter = (Start.X + end.X) / 2;
            int elipseCenterHeight = (Start.Y + end.Y) / 2;
            float sqaureX = (x - elipseCenter) * (x - elipseCenter);
            float sqaureY = (y - elipseCenterHeight) * (y - elipseCenterHeight);
            float a = width/2;
            float b = length/2;
            float sqaureA = a * a;
            float sqaureXB = b * b;
            if (Math.Abs((sqaureX / sqaureA) + (sqaureY / sqaureXB)) <=1)
                return true;
            else return false;
            //int radious;

            //  if(end.X<0)
            //  radious = Math.Abs(start.X + end.X) / 2;
            //  else
            //  radious = Math.Abs(start.X - end.X) / 2;


            // int mid_x, mid_y;
            // mid_x = (start.X + end.X) / 2;
            // mid_y = (start.Y + end.Y) / 2;
            // if (Math.Sqrt((mid_x - x) * (mid_x - x) + (mid_y - y) * (mid_y - y)) > radious) return false;
            //return Math.Abs(mid_x - x) <= width / 2 && Math.Abs(mid_y - y) <= length / 2;
            //if (Width == 0 || Length == 0) return false;
            //return (int)(((x * x) / ((Width / 2) * (Width / 2))) + ((y * y) /((Length / 2) * (Length / 2)))) <= 1;


            // x^2 / a^2 + y^2 / b^2 = 1   --- a = w/2  , b=h/2

        }

      
       
        

    }
}
