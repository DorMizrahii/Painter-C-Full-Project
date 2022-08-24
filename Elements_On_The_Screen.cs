using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
namespace WindowsFormsApp6
{
    [Serializable]    // Base Class
    abstract class Elements_On_The_Screen // we can enter here labl and picturs
    {
        
        public Point start; // the click point
        static protected int count= 0; //
        protected int id_;// for every shape other id
        public Point Start
        {
            get { return start; }
            set { start = value; }
        }

        public int Id_
        {
            get { return id_; }
            set { id_ = value; }
        }
        public abstract void Draw(  Bitmap bm, Graphics g);
        public abstract  bool Is_Inside(int x, int y);
    }
}
