using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_DuridAhmad
{
    class DeskQuote
    {
        Desk desk = new Desk();
        float totalPrice;
        float size;
        OrderType type;
        DateTime currentTime;



        //Getters and Setters
        public Desk Desk { get => desk; set => desk = value; }
        internal OrderType Type { get => type; set => type = value; }
        public DateTime CurrentTime { get => currentTime; set => currentTime = value; }


        //Constructor
        public DeskQuote()
        {
            type = OrderType.fourteen;
            totalPrice = 200;
        }
        private void calculateSize() => size = Desk.Width * Desk.Depth;

        //if the size is greater than 1000in squared add 50$ per extra inch squared
        private float sizePrice()
        {
            if (size > 1000) { return 50 * (size - 1000); }
            else return 0;
        }

        private float drawerPrice()
        {
            return desk.DrawerNum * 50;
        }
        //Adding the cost of material to the total price
        private float materialPrice()
        {
            float price = 0;
            switch (Desk.Type)
            {
                case SurfaceType.laminate:
                    price = 100;
                    break;
                case SurfaceType.oak:
                    price = 200;
                    break;
                case SurfaceType.pine:
                    price = 50;
                    break;
                case SurfaceType.roesewood:
                    price = 300;
                    break;
                case SurfaceType.veneer:
                    price = 125;
                    break;
            }
            return price;
        }

        //Depending on the desk size and order type extra charges will be added
        private float orderPrice()
        {
            float price = 0;
            switch (Type)
            {
                case OrderType.three:
                    if (size < 1000) { price = 60; }
                    else if (size > 1000 && size < 2000) { price = 70; }
                    else price = 80;
                    break;
                case OrderType.five:
                    if (size < 1000) { price = 40; }
                    else if (size > 1000 && size < 2000) { price = 50; }
                    else price = 60;
                    break;
                case OrderType.seven:
                    if (size < 1000) { price = 30; }
                    else if (size > 1000 && size < 2000) { price = 35; }
                    else price = 40;
                    break;
                case OrderType.fourteen:
                    price = 0;
                    break;
            }
            return price;
        }
        public float calculateTotal()
        {
            return totalPrice + sizePrice() + materialPrice() + orderPrice() + drawerPrice();
            
        }
    }
}
