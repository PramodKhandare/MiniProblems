using System;
using System.Collections.Generic;
using System.Text;
using LiftManagementSystem.BusinessLayer.Interface;

namespace LiftManagementSystem.BusinessLayer.Implementation
{
    public class Floor : IFloor
    {
        public Floor(int lf, int tf)
        {
            this.lowerFloor = lf;
            this.topFloor = tf;
        }

        public int lowerFloor { get; }
        public int topFloor { get; }
        public bool IsDoorOpen { get; set; }
    }
}
