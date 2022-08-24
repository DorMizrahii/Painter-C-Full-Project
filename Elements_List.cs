using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
namespace WindowsFormsApp6
{
    [Serializable]  
    class Elements_List
    {
        private SortedList MyElements;// we allowed to the user only hour methods for this class
        
        public Elements_List()
        {
            MyElements = new SortedList();
        }
        
        public int NextIndex// returnthe size of the list( and the next index to put element in)
        {
            get
            {
                return MyElements.Count;
            }
            //!!!
            // !! there is no set !!
        }
        public Elements_On_The_Screen this[int index] // operator [] for list
        {
            get
            {
                if (index >= MyElements.Count||index<0)
                    return (Elements_On_The_Screen)null;
                //SortedList internal method
                return (Elements_On_The_Screen)MyElements.GetByIndex(index);
            }
            set
            {
                if (index <= MyElements.Count&&index>=0)
                    MyElements[index] = value; //!!!		
            }
        }
        public void remove_all()
        {
            MyElements.Clear();
        }
        public void ADD(Elements_On_The_Screen e)
        {
            MyElements.Add(MyElements.Count, e); // ever item key is his index

        }
        public void Remove(int element)
        {
            if (element >= 0 && element < MyElements.Count) // we delete the item in index element and reduse the size by one
            {
                for (int i = element; i < MyElements.Count - 1; i++)
                    MyElements[i] = MyElements[i + 1];
                MyElements.RemoveAt(MyElements.Count - 1);
            }
        }

        // new method
        public void DrawAll( Bitmap bm,Graphics g)
        {
           
           
            for (int i = 0; i < MyElements.Count; i++)
                ((Elements_On_The_Screen)MyElements[i]).Draw(bm,g);
        }

    }
    //2e




}

