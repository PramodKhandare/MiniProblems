using System;
using System.Collections.Generic;
using System.Text;

namespace LiftManagementSystem.BusinessLayer.Interface
{
    public interface IFloor
    {
        public int lowerFloor { get; }
        public int topFloor { get; }
        public bool IsDoorOpen { get; set; }
    }
}
