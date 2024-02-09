using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Light_System
{
    public class Model
    {
        private TimeSpan time;
        private int counter_new_car; 
        private int counter_rem_car; 
        private LeftRightCount[] waitingcars; 
        private int CARS = 2; 
        public double SecForNewCar = 1.0; 
        public double SecForRemCar = 0.25; 
        private int counter_state;
        private int TimeCounterForBothRoads;
        private int counter_up_car;
        private int counter_down_car;
        private int counter_right_car;
        private int counter_left_car;
        private Model.STATE state = Model.STATE.stInit;
        private System.Timers.Timer timer = new System.Timers.Timer();

        public bool vert_allow() => this.state == Model.STATE.stVert; 
        public bool horz_allow() => this.state == Model.STATE.stHorz;


       
 




        public Model() => this.Reset();

        public void Reset()
        {
            this.time = TimeSpan.Zero;
            this.waitingcars = new LeftRightCount[this.CARS];
            for (int index = 0; index < this.CARS; ++index)
                this.waitingcars[index] = new LeftRightCount(); 
            this.counter_new_car = (int)(1000.0 * this.SecForNewCar); 
            this.counter_rem_car = (int)(1000.0 * this.SecForRemCar); 
            this.counter_state = 1000;
        }

        public void Update(TimeSpan dt,string navigation)
        {
            this.time += dt;
            this.counter_new_car -= (int)dt.TotalMilliseconds;
            if (this.counter_new_car <= 0)
            {
                this.counter_new_car = (int)(1000.0 * this.SecForNewCar);
                for (int index = 0; index < this.CARS; ++index)
                    this.waitingcars[index].Inc();
            }
            if (navigation.Equals("up"))
            {
                this.waitingcars[1].left++;
            }
            else if (navigation.Equals("down"))
            {
                this.waitingcars[1].right++;
            }
            else if (navigation.Equals("right"))
            {
                this.waitingcars[0].right++;
            }
            else if (navigation.Equals("left"))
            {
                this.waitingcars[0].left++;
            }

            if (this.horz_allow() && !this.vert_allow())
            {
                this.counter_rem_car -= (int)dt.TotalMilliseconds;
                if (this.counter_rem_car <= 0)
                {
                    this.counter_rem_car = (int)(1000.0 * this.SecForRemCar);
                    this.waitingcars[0].Dec();
                }
            }
            if (this.vert_allow() && !this.horz_allow())
            {
                this.counter_rem_car -= (int)dt.TotalMilliseconds;
                if (this.counter_rem_car <= 0)
                {
                    this.counter_rem_car = (int)(1000.0 * this.SecForRemCar);
                    this.waitingcars[1].Dec();
                }
            } 


            this.counter_state -= (int)dt.TotalMilliseconds;
            if (this.counter_state > 0)
                return;
            if (this.state == Model.STATE.stInit)
            {
                this.state = Model.STATE.stHorz;
                this.counter_state = 5000;
            }
            else if (this.state == Model.STATE.stHorz)
            {
                this.state = Model.STATE.stVert;
                this.counter_state = 5000;
            } 
            else if(this.state == Model.STATE.stVert)
            {
                this.state = Model.STATE.stHorz;
                this.counter_state = 5000;
            }
        } 
        public double getSec() => this.time.TotalSeconds;
         

        public LeftRightCount getLRcar(int i) => this.waitingcars[i];
       

        private enum STATE
        {
            stInit,
            stHorz,
            stVert, 
        }
    }
}
