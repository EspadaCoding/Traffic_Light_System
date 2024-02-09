using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Light_System
{
    public class Painter
    {
        private Model model; 
        private Car car;
        private _3Color c3;
        //timer;
          
        public Painter(Model Amodel)
        {
            this.model = Amodel; 
            this.car =  new Car();
            this.c3 = new _3Color();
             
        }  

        public void paintTo(Graphics G, int w, int h)
        {
            Brush brush1 = (Brush)new SolidBrush(Color.Black);
            Brush brush2 = (Brush)new SolidBrush(Color.Gray);
            Brush brush3 = (Brush)new SolidBrush(Color.White);
            Pen pen = new Pen(brush1);
            Font font = new Font("Arial", 14f);
            G.DrawLine(pen, 10, 10, w - 10, 10);
            G.DrawLine(pen, 10, h - 10, w - 10, h - 10);
            G.DrawLine(pen, 10, 10, 10, h - 10);
            G.DrawLine(pen, w - 10, 10, w - 10, h - 10);
            G.FillRectangle(brush2, w / 2 - 50, 11, 100, h - 20 - 1);
            G.FillRectangle(brush2, 10, h / 2 - 50, w - 20 - 1, 100);
            for (int index = 0; index < 4; ++index)
            {
                G.FillRectangle(brush3, w / 2 - 50 + index * 100 / 4, h / 2 - 50 - 50, 12, 50);
                G.FillRectangle(brush3, w / 2 - 50 + index * 100 / 4 + 12 + 1, h / 2 + 50, 12, 50);
                G.FillRectangle(brush3, w / 2 - 50 - 50, h / 2 - 50 + index * 100 / 4 + 12 + 1, 50, 12);
                G.FillRectangle(brush3, w / 2 + 50, h / 2 - 50 + index * 100 / 4, 50, 12);
            }
            //отрисовка по горизонтали 


            int num9 = w / 2 - 50 - 50 - this.car.Width() / 2;   //слева 
            int y3 = h / 2 + 50 - 25;
            for (int index = 0; index < this.model.getLRcar(0).left; ++index)
                this.car.paintTo(G, num9 - index * this.car.Width(), y3);

            int num10 = w / 2 + 50 + 50 + this.car.Width() / 2;      //справа  
            int y4 = h / 2 - 50 + 25;
            for (int index = 0; index < this.model.getLRcar(0).right; ++index)
                this.car.paintTo(G, num10 + index * this.car.Width(), y4);


            //отрисовка по вертикале

            //сверху
            int x3 = w / 2 - 50 + 25;
            int num11 = h / 2 - 50 - 50 - this.car.Height() / 2;
            for (int index = 0; index < this.model.getLRcar(1).left; ++index)
                this.car.paintTo(G, x3, num11 - index * this.car.Height());

            //снизу
            int x4 = w / 2 + 50 - 25;
            int num12 = h / 2 + 50 + 50 + this.car.Height() / 2;
            for (int index = 0; index < this.model.getLRcar(1).right; ++index)
                this.car.paintTo(G, x4, num12 + index * this.car.Height());


            //позиция светофора на дороге 
            //if(this.model.vert_allow())
            //{
            //    this.c3.setTag(_3Color.GO);
            //}
            //else
            //{
            //    //this.timer.Tick += new EventHandler(timer1_Tick);
            //    //this.timer.Start();
            //    this.c3.setTag(_3Color.WAIT); 
            //    this.c3.setTag(_3Color.STOP);
            //}
           this.c3.setTag(this.model.vert_allow() ? _3Color.GO : _3Color.STOP);
            this.c3.paintTo(G, w / 2 + 25, h / 2 - 150);//верхний светофор
            this.c3.paintTo(G, w / 2 - 25, h / 2 + 150);//нижний светофор
            //if (this.model.horz_allow())
            //{
            //    this.c3.setTag(_3Color.GO);
            //}
            //else
            //{  
            //        this.c3.setTag(_3Color.WAIT); 
            //    this.c3.setTag(_3Color.STOP);
            //}
            this.c3.setTag(this.model.horz_allow() ? _3Color.GO :  _3Color.STOP) ;
            this.c3.paintTo(G, w / 2 - 150, h / 2 - 25); //слева светофор
            this.c3.paintTo(G, w / 2 + 150, h / 2 + 25);//справа светофор

            G.DrawString("Time: " + this.model.getSec().ToString("F2") + " с.", font, brush1, 20f, 20f);
        }
    }
}