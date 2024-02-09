using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Light_System
{
    public class LeftRightCount
    {
        public int left;
        public int right; 

        public LeftRightCount()
        {
            this.left = 0;
            this.right = 0;
        }

        public void Inc()
        {
            ++this.left;
            ++this.right; 
        }

        public void Dec()
        {
            --this.left;
            --this.right;
            if (this.left < 0)
                this.left = 0;
            if (this.right >= 0)
                return;
            this.right = 0;
        }

      
        

    }
}
