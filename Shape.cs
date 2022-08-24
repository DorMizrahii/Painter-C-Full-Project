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
    abstract class Shape:Elements_On_The_Screen /// shape inside rectangle
    {

        protected int size_pen; // for the pen serialization
        protected int color;// for the pen serialization
        public Point  end;// the end of the shape
       
        
      
            
        //we dont have constractor in abstract class


       
        public Point End
        {
            get { return end; }
            set { end = value; }
        }
        public int Size_pen
        {
            get { return size_pen; }
            set { size_pen = value; }
        }
        public int COLOR
        {
            get { return color; }
            set { color = value; }
        }




        public abstract override void Draw( Bitmap bm, Graphics g);// for each shape


        public abstract override bool  Is_Inside(int x, int y); // for each shape

        
       










    }
}
