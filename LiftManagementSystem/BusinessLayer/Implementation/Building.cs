using System;
using System.Collections.Generic;
using System.Text;
using LiftManagementSystem.BusinessLayer.Interface;

namespace LiftManagementSystem.BusinessLayer.Implementation
{
    public class Building : IBuilding
    {
        IFloor floor = null;
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
