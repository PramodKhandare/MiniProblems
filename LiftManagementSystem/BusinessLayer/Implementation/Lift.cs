using System;
using System.Collections.Generic;
using System.Text;
using LiftManagementSystem.BusinessLayer.Interface;

namespace LiftManagementSystem.BusinessLayer.Implementation
{
    public class Lift : ILift
    {
        IFloor floor;
        public Lift(IBuilding b)
        {
            this.Building = b;
        }

        public IBuilding Building { get; set; }

        public void Move(IFloor floor)
        {
            this.floor = floor;

            //Actual logic of movement will come here
        }
       
    }
}
