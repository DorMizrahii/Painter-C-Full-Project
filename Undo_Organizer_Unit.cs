using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    [Serializable]
    public class Undo_Organizer_Unit// unit for the undo function
    {
        int mission; // 1 for add 2 for delete 3 for move
        int id;
        public Undo_Organizer_Unit(int mission,int id)
        {
            this.mission = mission;
            this.id = id;
            
        }
        public int Mission
        {
            get { return mission; }
            set { mission = value; }

        }
        public int Id
        {
            get { return id; }
            set { id = value; }

        }



    }
}
