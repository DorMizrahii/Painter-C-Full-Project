using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    [Serializable]
    class Bucket:Elements_On_The_Screen //Child of Element on the screen
    {
       public Stack<Point> dispersal;
        protected int color; // the color of the bucket
        public Bucket(Point start, int color)/// bucket without initalize (for moves) for undo and redo
        {
            this.start = start;
            this.color = color;
            this.dispersal = new Stack<Point>();
            count++;
            this.id_ = count;
        }
        public Bucket(Point start, int color,Bitmap bm)// we have to enter bm 
        {
            this.start = start;
            this.color = color; // the color we want to fill the shape
            dispersal = new Stack<Point>();
            count++;
            this.id_ = count;
            this.initiat(bm); // we draw the bucket on the constructor
        }
        public int COLOR
        {
            get { return color; }
            set { color = value; }
        }
        private  void validate(Bitmap bm, Stack<Point> this_dis, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y); //get the color of the picsel
            if (cx == old_color) // if the picksel eual to the old color(the color i klick on)
            {
                this_dis.Push(new Point(x, y));  // enter to the stuck
                dispersal.Push(this_dis.Peek());
                bm.SetPixel(x, y, new_color); // change the color
            }
        }
        public void initiat(Bitmap bm)// draw in the first time the color
        {

           
            Color old_color = bm.GetPixel(this.start.X, this.start.Y); // the old color is the color of the point
            if (old_color.ToArgb() == this.color) return;
            Stack<Point> this_dispersal = new Stack<Point>();
            this_dispersal.Push(new Point(this.start.X, this.start.Y)); // enter the old color inside
            dispersal.Push(this_dispersal.Peek());
            bm.SetPixel(this.start.X, this.start.Y, Color.FromArgb(this.color));// change the color for new color


            while (this_dispersal.Count > 0)
            {
                Point pt = (Point)this_dispersal.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, this_dispersal, pt.X - 1, pt.Y, old_color, Color.FromArgb(this.color));
                    validate(bm, this_dispersal, pt.X, pt.Y - 1, old_color, Color.FromArgb(this.color));
                    validate(bm, this_dispersal, pt.X + 1, pt.Y, old_color, Color.FromArgb(this.color));
                    validate(bm, this_dispersal, pt.X, pt.Y + 1, old_color, Color.FromArgb(this.color));
                }
            }
        }
        

        public override void Draw( Bitmap bm, Graphics g) // we want to draw when we undo or when we move
            {
            
            Point[] arr = dispersal.ToArray();
              try
             {
            for (int i = 0; i < arr.Length; i++)
            {
               
                bm.SetPixel(arr[i].X,arr[i].Y, Color.FromArgb(this.color));
            }
            }
            catch(Exception e)
            {
                //MessageBox.Show("out of range");
               // for(int i=0;i<arr.Length;i++)
                //{
                   // if (arr[i].X > 950|| arr[i].X <200)
                     //   arr[i].X = 600;
                
                       // if (arr[i].Y > 650||arr[i].Y<150)
                        //arr[i].Y = 350;
                    
               // }
            }
           
         
             }

        public override bool Is_Inside(int x, int y)// if one of the points is equall to the point -> true
        {
            Point[] arr = dispersal.ToArray();
            for (int i = 0; i < arr.Length; i++)
                if (x == arr[i].X && y == arr[i].Y)
                    return true;
            return false;


        }
    }

    }

