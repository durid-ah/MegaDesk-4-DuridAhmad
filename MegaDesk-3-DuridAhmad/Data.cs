using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_DuridAhmad
{
    public class QuoteData
    {
        string name;
        int width;
        int depth;
        int drawers;
        SurfaceType materialType;
        string material;
        OrderType orderType;
        string order;
        DateTime date;
        int total;
        public QuoteData() { }
        QuoteData(string name, int width, int depth, int drawers,
        SurfaceType material, OrderType order, DateTime date, int total)
        {
            this.Name = name;
            this.Width = width;
            this.Depth = depth;
            this.Drawers = drawers;
            this.MaterialType = material;
            this.OrderType = order;
            this.Date = date;
            this.Total = total;
        }

        public string Name { get => name; set => name = value; }
        public int Width { get => width; set => width = value; }
        public int Depth { get => depth; set => depth = value; }
        public int Drawers { get => drawers; set => drawers = value; }
        public string Material { get => material; set => material = value; }
        public string Order { get { return order; } set { order = value; } }
        public DateTime Date { get => date; set => date = value; }
        public int Total { get => total; set => total = value; }
        internal SurfaceType MaterialType { get => materialType; set => materialType = value; }
        internal OrderType OrderType { get => orderType; set => orderType = value; }
    }


    public class Data
    {
        string name;
        int width;
        int depth;
        int drawers;
        SurfaceType material;
        OrderType order;
        DateTime date;
        int total;
        public Data() { }
        Data(string name, int width, int depth, int drawers,
        SurfaceType material, OrderType order, DateTime date, int total)
        {
            this.name = name;
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.material = material;
            this.order = order;
            this.date = date;
            this.total = total;
        }

    }
}
