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
    class Mypen :Shape
    {

        public Point[] arr; /// good for restore
        int size;

        public Mypen(int color, int size_pen, Point start, Point end,int size,Point[] brr) {
            this.color = color; this.size_pen = size_pen;
            this.start = start; this.end = end;
            this.size = size;
            arr = new Point[size];
            for (int i = 0; i < size; i++)
                arr[i] = brr[i];
            count++;
            this.id_ = count;

        }

        public Point[] Arr
            {
            get{ return arr; }
            set { arr = value; }
            }
        
        public override void Draw(Bitmap bm, Graphics g)
        {
           for(int i=0;i<size-1;i++)
            {
                g.DrawLine(new Pen(Color.FromArgb(color), size_pen),arr[i],arr[i+1]);
            }



        }

        public override bool Is_Inside(int x, int y) 
        {

           //  int max_x=arr[2].X, max_y= arr[2].Y, min_x= arr[2].X, min_y= arr[2].Y;
             //int mid_x, mid_y;
             for(int i=0;i<size;i++)
             {
                if (Math.Abs(arr[i].X - x) <= 10 && Math.Abs(arr[i].Y - y) <= 10)
                    return true;
                        
             }
            return false;
           
        }
        


    }
}
