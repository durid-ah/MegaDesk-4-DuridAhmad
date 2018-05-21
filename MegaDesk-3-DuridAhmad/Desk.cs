using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_DuridAhmad
{
    class Desk
    {
        //the variables
        string ownerName;
        float width;
        float depth;
        int drawerNum;
        SurfaceType type;

        public Desk()
        {
            ownerName = null;
            width = 24;
            depth = 12;
            drawerNum = 7;
            type = SurfaceType.laminate;
        }

        public string OwnerName { get => ownerName; set => ownerName = value; }
        public float Width { get => width; set => width = value; }
        public float Depth { get => depth; set => depth = value; }
        public int DrawerNum { get => drawerNum; set => drawerNum = value; }
        internal SurfaceType Type { get => type; set => type = value; }
    }
}
