using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Light_System
{
    internal class _3Color  
    {
        private Brush black;
        private Brush red;
        private Brush yellow;
        private Brush green;
        private Brush gray; 
        private int Tag;
        public static int GO = 1;
        public static int WAIT = 2;
        public static int STOP = 3;

        public _3Color()
        {
            this.black = (Brush)new SolidBrush(Color.Black);
            this.green = (Brush)new SolidBrush(Color.Green);
            this.red = (Brush)new SolidBrush(Color.Red);
            this.gray = (Brush)new SolidBrush(Color.Gray);
            this.yellow = (Brush)new SolidBrush(Color.Yellow);
            this.setTag(_3Color.STOP);
        }


        //отрисовка светофора
        public   void paintTo(Graphics G, int x, int y)
        {
            G.FillRectangle(this.black, x - this.Width() / 2, y - this.Height() / 2, this.Width(), this.Height());
            G.FillEllipse(this.Tag == _3Color.GO ? this.green : this.gray, x - 7, y - this.Height() / 4 - 7, 2 * 7, 2 * 7);
            G.FillEllipse(this.Tag == _3Color.STOP ? this.red : this.gray, x - 7, y + this.Height() / 4 - 7, 2 * 7, 2 * 7);


            //G.FillRectangle(this.black, x - this.Width() / 2, y - this.Height() / 2, this.Width(), this.Height() + 25);
            //G.FillEllipse(this.Tag == _3Color.WAIT ? this.yellow : this.gray, x - 7, y + this.Height() / 4 - 7, 2 * 7, 2 * 7);
            //G.FillEllipse(this.Tag == _3Color.STOP ? this.red : this.gray, x - 7, y - this.Height() / 4 - 7, 2 * 7, 2 * 7);
            //G.FillEllipse(this.Tag == _3Color.GO ? this.green : this.gray, x - 7, y + this.Height() - 14, 2 * 7, 2 * 7);



        }

        public   int Width() => 20;
        public void setTag(int ATag) => this.Tag = ATag;
        public   int Height() => 40;
    }
}
