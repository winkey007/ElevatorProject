using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.Model
{
    public class Result
    {
        private int NumIdleTransport;
        private float TotalWeight;
        private int NumTransported;

        public int getNumIdleTransport()
        {
            return NumIdleTransport;
        }
        public void setNumIdleTransport(int numIdleTransport)
        {
            NumIdleTransport = numIdleTransport;
        }
        public int getNumTransported()
        {
            return NumTransported;
        }
        public void setNumTransported(int numTransported)
        {
            NumTransported = numTransported;
        }
        public float getTotalWeight()
        {
            return TotalWeight;
        }
        public void setTotalWeight(float totalWeight)
        {
            TotalWeight = totalWeight;
        }
    }
}
