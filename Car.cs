using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Light_System
{
    internal class Car  
    {
        private Image img;

        public Car() => this.img = Image.FromFile("car.png");

        public void paintTo(Graphics G, int x, int y)
        {
            G.DrawImage(this.img, x - this.img.Width / 2, y - this.img.Height / 2, this.img.Width / 1, this.img.Height / 1);
        }

        public  int Width() => this.img.Width; 
        public  int Height() => this.img.Height;
    }
}
