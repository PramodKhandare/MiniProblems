using System;
using System.Collections.Generic;
using System.Text;

namespace LiftManagementSystem.BusinessLayer.Interface
{
    interface ILift
    {
        public IBuilding Building { get; set; }
        void Move(IFloor floor);               
    }
}
