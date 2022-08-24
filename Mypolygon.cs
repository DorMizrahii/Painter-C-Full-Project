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
    class Mypolygon:Shape // polygone is actually array of points
        
    {
      
        int size;
        int angle;
        int length;
        int increment;
        public Mypolygon(int color, int size_pen, Point start,Point end, int size,int angle,int length,int increment )
        {
            this.color = color;
            this.size_pen = size_pen;
            this.start = start;
            this.end = end;
            this.size = size;
            this.angle = angle;
            this.length = length;
            this.increment = increment;
            count++;
            this.id_ = count;
        }


       

        public override void Draw( Bitmap bm, Graphics g)
        {
           

            int angel_original = angle;
            int lenth_original = this.length;
            int incroment_original = this.increment;
            Point start_or = this.start; //Origanl Points
            Point end_or = this.end;

            for (int i = 0; i < size; i++)
            {
                // array of points
                this.end.X = (int)(this.start.X + Math.Cos(angle * 0.017453292519) * length);
                this.end.Y = (int)(this.start.Y + Math.Sin(angle * 0.017453292519) * length);
                Point[] temp = { new Point(this.Start.X, this.Start.Y), new Point(this.End.X, this.End.Y) };
                g.DrawLines(new Pen(Color.FromArgb(color), size_pen), temp);
                this.start.X = this.end.X;
                this.start.Y = this.end.Y;
                angle += angel_original;
                length += increment;
        

            }
            this.angle = angel_original;
            this.length = lenth_original;
            this.increment = incroment_original;
            this.end = end_or;
            this.start = start_or;


        }
         public override bool Is_Inside(int x, int y)
        {
            //int mid_x, mid_y;
            // mid_x = 1100 / 2;
            ////mid_y = 750 / 2;
            //return Math.Abs(mid_x - x) <= 100 && Math.Abs(mid_y - y) <= 100;
            return false; // this prototype dosnt allow to move this object or to clear it :)
        }
        

    }

    }

