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
using System.IO;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsApp6
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            this.Width = 1250;
            this.Height = 800;
            bm = new Bitmap(pic.Width, pic.Height);//maybe
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
            

        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;// points in the mouse move ( to paint myPen,the end will be the start of the next point we need to save the last cordinates for continue)
        Pen p = new Pen(Color.Black, 4);
        int index;// the index - our abilities in the aplication
        int x, y, sX, sY, cX, cY;// the current x, y the click x, y and the delta x, y
        ColorDialog cd_ = new ColorDialog();
        Color new_color; // new color in order to change the color by the picture
        int pen_color=Color.Black.ToArgb(); int pen_size=4;// pen dm, for creat a pen
       
        List<Point> mypen_p = new List<Point>();// in order to create my pen we need point[]
       
        Elements_On_The_Screen loked;// the item me move
        bool is_press = false;// do we move object?
        int  ore_x_s=0, ore_y_s=0, ore_x_e=0, ore_y_e=0;// the original points of the object
        Point[] prr; // the point of my pen when we move it (for moving the pen) 
        Point[] p_bucket;// the points of the bucket when we move it ( for moving the bucket)
        Elements_List myelements = new Elements_List();// the list wich save our elements
        Elements_List deleted = new Elements_List();//save all the deleted items in list (for undo and redo)
      // save all the undo items wich deleted in list
        Elements_List moved= new Elements_List();
        Stack<Undo_Organizer_Unit> the_undo_orgnized = new Stack<Undo_Organizer_Unit>();// 1= erase,2=add, 3=move
        Stack<Undo_Organizer_Unit> the_redo_orgnized = new Stack<Undo_Organizer_Unit>();
        Elements_List moved_redo = new Elements_List();
        Elements_List deleted_redo = new Elements_List();

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            Point[] brr;
          
            if (index == 9) //need to move the object
            {
                if (is_press) // we found the object
                {
                    px = e.Location;
                    if (loked.GetType() == typeof(Mypen))
                    {
                        for (int j = 0; j < ((Mypen)loked).arr.Length; j++) // we ofsets the points of my pen
                        {
                            ((Mypen)loked).arr[j].X = prr[j].X + sX;
                            ((Mypen)loked).arr[j].Y = prr[j].Y + sY;
                        }

                    }
                    else if (loked.GetType() == typeof(Bucket))
                    {
                        brr = ((Bucket)loked).dispersal.ToArray();
                        ((Bucket)loked).dispersal.Clear();
                        for (int j = brr.Length - 1; j >= 0; j--)
                        {
                            brr[j].X = p_bucket[j].X + sX;
                            brr[j].Y = p_bucket[j].Y + sY;
                            ((Bucket)loked).dispersal.Push(brr[j]);
                        }


                    }
                    else
                    {
                        ((Shape)loked).start.X = ore_x_s + sX;
                        ((Shape)loked).start.Y = ore_y_s + sY;

                        ((Shape)loked).end.X = ore_x_e + sX;

                        ((Shape)loked).end.Y = ore_y_e + sY;
                    }
                    g.Clear(Color.White);
                    pic.Image = bm;

                    myelements.DrawAll(bm, g);
                    loked.Draw(bm, g);
                    py = px;
                }

            }
            if (paint)
            {
                    if (index == 2)  // erase
                    {
                        
                       for(int i=myelements.NextIndex-1;i>=0;i--)// we from the end to the start
                        {
                            
                            if (myelements[i].Is_Inside(e.X, e.Y)) 
                            {
                            deleted.ADD(myelements[i]);// we save the element
                            myelements.Remove(i);// delete the item in the place of i
                            g.Clear(Color.White); // we clear all and draw again
                            pic.Image = bm;
                            myelements.DrawAll(bm, g);
                            the_undo_orgnized.Push(new Undo_Organizer_Unit(1,deleted[deleted.NextIndex-1].Id_)); //for add
                           
                            break;
                            }
                        }
                        
                        

                    }

                if (index == 1)// mypen
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    mypen_p.Add(px);
                    py = px; //  py = prev point , px = next point
                }
                }
                pic.Refresh();
                x = e.X;
                y = e.Y;
                sX = e.X - cX;
                sY = e.Y - cY;
            textBox1.Text = myelements.NextIndex.ToString();
           // if(the_undo_orgnized.Count!=0)
         //   textBox2.Text = the_undo_orgnized.Peek().Id.ToString();
        }
        

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
           
            Point[] arr = new Point[mypen_p.Count];
           // Stack<Elements_On_The_Screen> brr = new Stack<Elements_On_The_Screen>();
            mypen_p.CopyTo(arr);
            paint = false;
           
           // if(loked==null)
               // priority_to_move = 0;

            sX = x - cX;
            sY = y - cY;
            int sx_abs= Math.Abs(x - cX); int sy_abs= Math.Abs(y - cY);
            int minX = x > cX ? cX : x;
            int minY = y > cY ? cY : y;

            int maxX = x < cX ? cX : x;
            int maxY = y < cY ? cY : y;



           // sX = x - cX;
           // sY = y - cY;
            if(index==1)
            {
                
                myelements.ADD((new Mypen(pen_color, pen_size, new Point(cX, cY), new Point(x, y), mypen_p.Count, arr)));
                mypen_p.Clear(); // to clear the arrays
                the_undo_orgnized.Push(new Undo_Organizer_Unit(2, myelements[myelements.NextIndex-1].Id_)); ; //erase = 2 for erase elements
            }

            if (index == 3)
            {
                myelements.ADD((new Circle(pen_color, pen_size, new Point(cX, cY), new Point(x, y), sX, sY)));

                myelements[myelements.NextIndex-1].Draw( bm, g);
                the_undo_orgnized.Push(new Undo_Organizer_Unit(2, myelements[myelements.NextIndex - 1].Id_));
            }
            if (index == 4)
            {
                myelements.ADD ((new Myrectangle(pen_color, pen_size, new Point(minX, minY), new Point(maxX, maxY), sx_abs, sy_abs)));

                myelements[myelements.NextIndex - 1].Draw( bm, g);
                the_undo_orgnized.Push(new Undo_Organizer_Unit(2, myelements[myelements.NextIndex - 1].Id_));
            }
            if (index == 5)
            {
                myelements.ADD((new Line(pen_color, pen_size, new Point(cX, cY), new Point(x, y))));

                myelements[myelements.NextIndex - 1].Draw( bm, g);
                the_undo_orgnized.Push(new Undo_Organizer_Unit(2, myelements[myelements.NextIndex - 1].Id_));
            }
            if(index==9)
            {
                if (is_press)
                {


                    //if(loked.GetType()==typeof(Mypen))
                    //{
                    //    //((Mypen)loked).start = ((Mypen)loked).arr[0];
                    //    //((Mypen)loked).end = ((Mypen)loked).arr[((Mypen)loked).arr.Length-1];
                    //}
                   
                   myelements.ADD(loked);
                    g.Clear(Color.White);
                    pic.Image = bm;
                    the_undo_orgnized.Push(new Undo_Organizer_Unit(3, myelements[myelements.NextIndex - 1].Id_));// move
                  

                    loked = null;
                  
                    is_press = false;

                    myelements.DrawAll(bm, g);
                    

                }
               // if (the_undo_orgnized.Count != 0)
                  ///  textBox2.Text = the_undo_orgnized.Peek().Id.ToString();

                textBox1.Text = myelements.NextIndex.ToString();
            }
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
            
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

     
        static Point set_point(PictureBox pb, Point pt) // GOOD IN ORDER TO GET THE RIGHT X Y IN PROPECIONAL TO THE SCREAN SIZE
        {
            float pX = 1f * pb.Image.Width / pb.Width;  // inorder to get the currect quality 
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }
        
        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
          //  Point point = set_point(color_picker, e.Location);
            //pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);// get the color of the picture click
           // new_color = pic_color.BackColor;
           // p.Color = pic_color.BackColor;
            //pen_color = p.Color.ToArgb();
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            sX = x - cX;
            sY = y - cY;
            int sx_abs = Math.Abs(x - cX); int sy_abs = Math.Abs(y - cY);
            int minX = x > cX ? cX : x;
            int minY = y > cY ? cY : y;

            int maxX = x < cX ? cX : x;
            int maxY = y < cY ? cY : y;
            if (paint)
            {
              

                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, minX, minY, sx_abs, sy_abs);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
              


            }
        }
       
        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 7;

        }
        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            //Stack<Shape> brr = new Stack<Shape>();
            //Elements_On_The_Screen[] drr;
            //bool erase = false;
            //Stack<Elements_On_The_Screen> crr;
           

            if (index == 7) // bucket
            {
                    Point point = set_point(pic, e.Location); // take the x y of the click //// the function take points and change the reselicya to right form
                    Bucket b = new Bucket(point, p.Color.ToArgb(),bm);// when we creat the bucket we drow it
                    myelements.ADD(b);// enter the new bucket to the elements stuck
                the_undo_orgnized.Push(new Undo_Organizer_Unit(2, myelements[myelements.NextIndex - 1].Id_));//mission 2 delete



                // }
            }
            if (index == 2)  // erase
            {
                for (int i = myelements.NextIndex - 1; i >= 0; i--)// we from the end to the start
                {

                    if (myelements[i].Is_Inside(e.X, e.Y))
                    {
                        deleted.ADD(myelements[i]);
                        myelements.Remove(i);// delete the item in the place of i
                        g.Clear(Color.White); // we clear all and draw again
                        pic.Image = bm;
                        myelements.DrawAll(bm, g);
                        the_undo_orgnized.Push(new Undo_Organizer_Unit(1, deleted[deleted.NextIndex - 1].Id_));//mission 1 add
                        //undo_delte = 1;
                        break;
                    }



                }
            }
            textBox1.Text = myelements.NextIndex.ToString();
          //  if (the_undo_orgnized.Count != 0)
               // textBox2.Text = the_undo_orgnized.Peek().Id.ToString();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
           
                
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "Paint files(*.PNT)| *.PNT | All files(*.*) | *.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //!!!!
                    formatter.Serialize(stream,myelements);
                    MessageBox.Show("The file has been saved");
                }
            }
        }
     



        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void color_picker_Click(object sender, EventArgs e)
        {

        }

        private void btn_polygon_Click(object sender, EventArgs e)
        {
           
          // polygon
            Mypolygon poly = new Mypolygon(p.Color.ToArgb(),pen_size, new Point(pic.Width / 2, pic.Height / 2), new Point(pic.Width / 2 +50, pic.Height / 2 + 50), Int32.Parse(box_points.Text), Int32.Parse(box_angel.Text), Int32.Parse(box_length.Text),Int32.Parse(books_increm.Text));
            myelements.ADD(poly);
            poly.Draw( bm, g);

        }

        private void btn_thick_Click(object sender, EventArgs e)
        {
            //p.Width++;
            //pen_size++;
        }

        private void btn_tin_Click(object sender, EventArgs e)
        {
            //if(p.Width>0)
            //p.Width--;
            //pen_size--;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_points_Click(object sender, EventArgs e)
        {

        }

        private void btn_length_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
           List<Shape> b;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "Paint files(*.PNT)| *.PNT | All files(*.*) | *.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //!!!!
               myelements = (Elements_List)binaryFormatter.Deserialize(stream);

                myelements.DrawAll(bm, g);


            }


        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_redo_Click(object sender, EventArgs e)
        {
            Undo_Organizer_Unit task = null;
            if (the_redo_orgnized.Count != 0)
                task = the_redo_orgnized.Pop();

            if(task!=null)
            {
                if(task.Mission==1) // add
                {
                    for (int i= deleted_redo.NextIndex - 1; i >= 0;i--)
                    {

                        if(deleted_redo[i].Id_==task.Id)
                        {
                           myelements.ADD(deleted_redo[i]);
                            the_undo_orgnized.Push(new Undo_Organizer_Unit(2, deleted_redo[i].Id_));
                            deleted_redo.Remove(i);
                            break;
                        }

                    }
                    g.Clear(Color.White);
                    pic.Image = bm;
                    myelements.DrawAll(bm, g);

                }

                if (task.Mission==2)// del
                {
                    for (int i = myelements.NextIndex - 1; i >= 0; i--)
                    {
                        if (myelements[i].Id_ == task.Id)
                        {
                           
                            deleted.ADD(myelements[i]);
                            the_undo_orgnized.Push(new Undo_Organizer_Unit(1, myelements[i].Id_));
                            myelements.Remove(i);
                            break;
                        }
                    }

                    g.Clear(Color.White);
                    pic.Image = bm;
                    myelements.DrawAll(bm, g);


                }


                if (task.Mission==3)// move
                {
                    for (int i = myelements.NextIndex - 1; i >= 0; i--)
                    {
                        if (myelements[i].Id_ == task.Id)
                        {
                            
                            moved.ADD(myelements[i]);
                            myelements.Remove(i);
                            break;
                        }
                    }
                    for (int i = moved_redo.NextIndex - 1; i >= 0; i--)
                    {
                        if (moved_redo[i].Id_ == task.Id)
                        {
                            the_undo_orgnized.Push(new Undo_Organizer_Unit(3, moved_redo[i].Id_));
                            myelements.ADD(moved_redo[i]);
                            moved_redo.Remove(i);
                            break;
                        }
                    }
                    g.Clear(Color.White);
                    pic.Image = bm;
                    myelements.DrawAll(bm, g);




                }



            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd_.ShowDialog();
            new_color = cd_.Color;
            pic_color.BackColor = cd_.Color;
            p.Color = cd_.Color;
            pen_color = p.Color.ToArgb();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            p.Width = trackBar1.Value;
            pen_size = ((int)p.Width);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            Undo_Organizer_Unit task = null;
            
            if (the_undo_orgnized.Count != 0)
                task = the_undo_orgnized.Pop();
            if (task != null)
            {
                if (task.Mission == 1) // add
                {
                    for(int i=deleted.NextIndex-1;i>=0;i--)
                    {
                        if(deleted[i].Id_==task.Id)
                        {
                            the_redo_orgnized.Push(new Undo_Organizer_Unit(2, deleted[i].Id_));// the opposite task  to redo = delete 2
                            myelements.ADD(deleted[i]);
                            deleted.Remove(i);
                            break;
                        }
                    }
                    g.Clear(Color.White);
                    pic.Image = bm;
                    myelements.DrawAll(bm, g);

                }
                else if (task.Mission == 2)//del
                {
                    for(int i=myelements.NextIndex-1;i>=0;i--)
                    {
                        if(myelements[i].Id_==task.Id)
                        {
                            the_redo_orgnized.Push(new Undo_Organizer_Unit(1, myelements[i].Id_));//add
                            deleted_redo.ADD(myelements[i]);
                            myelements.Remove(i);
                            break;
                        }
                    }
                    g.Clear(Color.White);
                    pic.Image = bm;
                    myelements.DrawAll(bm, g);


                }

                else if (task.Mission == 3)// move
                {
                    for (int i = myelements.NextIndex - 1; i >= 0; i--)
                    {
                        if (myelements[i].Id_ == task.Id)
                        {
                            
                            moved_redo.ADD(myelements[i]);//add in redo
                            myelements.Remove(i);
                            break;
                        }
                    }
                    for (int i= moved.NextIndex-1; i>=0;i--)
                    {
                        if(moved[i].Id_==task.Id)
                        {
                            the_redo_orgnized.Push(new Undo_Organizer_Unit(3, moved[i].Id_));//del in redo
                            myelements.ADD(moved[i]);
                            moved.Remove(i);
                            break;
                        }
                    }
                    g.Clear(Color.White);
                    pic.Image = bm;
                    myelements.DrawAll(bm, g);


                }
            }


            
            textBox1.Text = myelements.NextIndex.ToString();
           // if (the_undo_orgnized.Count != 0)
              //  textBox2.Text = the_undo_orgnized.Peek().Id.ToString();

        }
            

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            index = 9;
        }

       

        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
            myelements.remove_all();
            deleted.remove_all();
            moved_redo.remove_all();
            deleted_redo.remove_all();
            moved.remove_all(); // save object only if we have objects
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            Bucket b;
            Elements_On_The_Screen temp;
            //Elements_On_The_Screen[] arr;
            py = e.Location;
            cX = e.X;
            cY = e.Y;
            paint = true;
            if (index == 1)
            {
                mypen_p.Add(py); // mypen
            }

          
            
            if (index == 9)  /// move objects
            {
                

               for(int i=myelements.NextIndex-1;i>=0;i--)
                {
                    temp = myelements[i];
                    
                    if (temp.Is_Inside(e.X, e.Y)) // for every shape we have is inside
                    {
                        is_press = true;
                        loked = temp;
                        myelements.Remove(i);
                       
                       
                        if (loked.GetType() == typeof(Mypen))// we need to copy all the points
                        {
                            prr = new Point[((Mypen)loked).arr.Length];
                            for (int j = 0; j < ((Mypen)loked).arr.Length; j++)
                            {
                                prr[j].X = ((Mypen)loked).arr[j].X; // now prr store these original points of mypen
                                prr[j].Y = ((Mypen)loked).arr[j].Y;
                            }
                            moved.ADD(new Mypen(((Mypen)(loked)).COLOR, ((Mypen)(loked)).Size_pen, ((Mypen)(loked)).Start, ((Mypen)(loked)).End, ((Mypen)(loked)).arr.Length, ((Mypen)(loked)).arr));
                            ((Mypen)(moved[moved.NextIndex - 1])).Id_ = loked.Id_;
                        }
                        if(loked.GetType()==typeof(Bucket))
                        {
                            
                            p_bucket = ((Bucket)loked).dispersal.ToArray();
                            b=new Bucket(loked.Start, ((Bucket)(loked)).COLOR);
                            for (int j = 0; j < p_bucket.Length; j++)
                               b.dispersal.Push(p_bucket[j]);
                           moved.ADD(b);
                            moved[moved.NextIndex - 1].Id_ = loked.Id_;
                           
                        }
                        else
                        {
                            ore_x_s = ((Shape)loked).Start.X; ore_y_s = ((Shape)loked).Start.Y; // taking the x y
                            ore_x_e = ((Shape)loked).End.X; ore_y_e = ((Shape)loked).End.Y;  //of the original shape
                           if(loked.GetType()==typeof(Line))
                            {
                               moved.ADD(new Line(((Line)(loked)).COLOR, ((Line)(loked)).Size_pen, ((Line)(loked)).Start, ((Line)(loked)).End));
                                ((Line)(moved[moved.NextIndex - 1])).Id_ = loked.Id_;
                            }
                            if (loked.GetType() == typeof(Myrectangle))
                           {
                                moved.ADD(new Myrectangle(((Myrectangle)(loked)).COLOR, ((Myrectangle)(loked)).Size_pen, ((Myrectangle)(loked)).Start, ((Myrectangle)(loked)).End, ((Myrectangle)(loked)).Width, ((Myrectangle)(loked)).Length));
                                ((Myrectangle)(moved[moved.NextIndex - 1])).Id_ = loked.Id_;
                            }
                            if (loked.GetType() == typeof(Circle))
                            {
                                moved.ADD(new Circle(((Circle)(loked)).COLOR, ((Circle)(loked)).Size_pen, ((Circle)(loked)).Start, ((Circle)(loked)).End, ((Circle)(loked)).Width, ((Circle)(loked)).Length));
                                ((Circle)(moved[moved.NextIndex - 1])).Id_ = loked.Id_;
                            }
                        }

                        break;
                    }
                    
                }
               
                
            }
            textBox1.Text = myelements.NextIndex.ToString();
           //  if (the_undo_orgnized.Count != 0)
              //  textBox2.Text = the_undo_orgnized.Peek().Id.ToString();
        }
            private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void pic_color_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
